using System;
using System.Data;
using System.Text;
using ModelsLibrary.Properties;
using MySql.Data.MySqlClient;

namespace ModelsLibrary
{
    internal static class DatabaseController
    {
        //public static string DatabaseName;
        //public static string Password;
        //public static uint Port;
        //public static string Server;
        public static MySqlConnection SharedDbConnection;
        //public static string UserName;


        public static int ExecuteInsertQuery(string sqlInsert, params SqlParameter[] sqlParameters)
        {

            if (sqlInsert == string.Empty) return 0;

            if (SharedDbConnection != null)
            {
                var sqlCommand = new MySqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = sqlInsert,
                    Connection = SharedDbConnection
                };

                foreach (SqlParameter parameter in sqlParameters)
                {
                    sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                if (SharedDbConnection.State != ConnectionState.Open)
                {
                    SharedDbConnection.Open();
                }
                int sqlResult = sqlCommand.ExecuteNonQuery();
                if (sqlResult > 0)
                {
                    sqlCommand.CommandText = "SELECT LAST_INSERT_ID()";
                    sqlCommand.Parameters.Clear();
                    sqlResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                SharedDbConnection.Close();
                
                Write(sqlInsert);

                return sqlResult;
            }
            if (Validate())
            {
                return ExecuteInsertQuery(sqlInsert, sqlParameters);
            }
            throw new Exception("ExecuteInsertQuery failed.");
        }

        public static int ExecuteNonQuery(string sqlStatement, params SqlParameter[] sqlParameters)
        {
            if (SharedDbConnection != null)
            {
                var sqlCommand = new MySqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = sqlStatement,
                    Connection = SharedDbConnection
                };

                foreach (SqlParameter parameter in sqlParameters)
                {
                    sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                if (SharedDbConnection.State != ConnectionState.Open)
                {
                    SharedDbConnection.Open();
                }
                int sqlResult = sqlCommand.ExecuteNonQuery();

                Write(sqlStatement);

                return sqlResult;
            }
            if (Validate())
            {
                return ExecuteInsertQuery(sqlStatement, sqlParameters);
            }
            throw new Exception("ExecuteNonQuery failed.");
        }

        public static DataTable ExecuteSelectQuery(string sqlSelect, params SqlParameter[] parameters)
        {
            if (SharedDbConnection == null)
            {
                Validate();
            }

            var sqlCommand = new MySqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = sqlSelect,
                Connection = SharedDbConnection
            };
            foreach (SqlParameter parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            var dataAdapter = new MySqlDataAdapter(sqlCommand);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Write(sqlSelect);

            return dataTable;
        }

        public static DataTable ExecuteSelectQuery(StringBuilder sqlBuilder)
        {
            return ExecuteSelectQuery(sqlBuilder.ToString());
        }

        public static DataTable ExecuteSelectQuery(StringBuilder sqlBuilder, SqlParameter sqlParam)
        {
            return ExecuteSelectQuery(sqlBuilder.ToString(), sqlParam);
        }

        public static DataTable ExecuteStoredProcedure(string storedProcedure, params SqlParameter[] parameters)
        {
            if (SharedDbConnection == null)
            {
                Validate();
            }

            var sqlCommand = new MySqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = storedProcedure,
                Connection = SharedDbConnection
            };
            foreach (SqlParameter parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            var dataAdapter = new MySqlDataAdapter(sqlCommand);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Write(storedProcedure);

            return dataTable;
        }

        public static bool Validate()
        {
            bool functionReturnValue;
            try
            {
                var toReturnValue = new DataTable();
                var connectionBuilder = new MySqlConnectionStringBuilder
                {
                    Server = Settings.Default.DatabaseServer,
                    Port = Settings.Default.DatabasePort,
                    Database = Settings.Default.DatabaseName,
                    UserID = Settings.Default.DatabaseUser,
                    Password = Utilities.Decrypt(Settings.Default.DatabasePassword),
                    ConnectionTimeout = 60,
                    DefaultCommandTimeout = 60,
                    AllowZeroDateTime = false,
                    ConvertZeroDateTime = true,
                    RespectBinaryFlags = false
                };
                var sqlConnection = new MySqlConnection(connectionBuilder.ToString());
                using (var dbAdapter = new MySqlDataAdapter("SHOW TABLES", sqlConnection))
                {
                    dbAdapter.Fill(toReturnValue);
                    if (toReturnValue.Rows.Count == 0)
                    {
                        dbAdapter.Fill(toReturnValue);
                    }
                }
                functionReturnValue = true;
                SharedDbConnection = sqlConnection;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.Message);
                functionReturnValue = false;
            }
            return functionReturnValue;
        }

        private static void Write(string sql)
        {
            Console.WriteLine();
            Console.WriteLine(sql);         
        }
    }

}
