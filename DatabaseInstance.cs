using System;

namespace ModelsLibrary
{
    public static class DatabaseInstance
    {
        public static void Initialize()
        {
            if(!DatabaseController.Validate())
            {
                throw new Exception("Database configuration invalid");
            }
        }
    }
}
