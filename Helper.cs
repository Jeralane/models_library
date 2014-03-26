using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ModelsLibrary
{
    public static class StringHelper
    {
        #region --- Pluralize ---

        public static string Pluralize(int count, string word) 
        {
            if (count <= 1) return word;
            return Pluralize(word);
        }

        public static string Pluralize(string word)
        {
            word = word.Trim();

            if (_mutatedWords == null)
            {
                InitializeMutatedWords();
            }
            if (_mutatedWords.ContainsKey(word))
            {
                return _mutatedWords[word];
            }

            // get the last two letters
            var suffix = GetSuffix(2, word).ToLower();
            switch (suffix)
            {
                case "ch":
                    return word + "es";

                case "oe":
                    return word + "s";
            }

            // get the last letter
            suffix = GetSuffix(1, word);
            switch (suffix)
            {
                case "x":
                case "s":
                    return word + "es";
            }

            return word + "s";
        }

        private static string GetSuffix(int count, string word)
        {
            return word.Substring(word.Length - count);
        }

        private static Dictionary<string, string> _mutatedWords;

        private static void InitializeMutatedWords()
        {
            _mutatedWords = new Dictionary<string, string>();
            _mutatedWords.Add("child", "children");
            _mutatedWords.Add("woman", "women");
            _mutatedWords.Add("man", "men");
            _mutatedWords.Add("person", "people");
            _mutatedWords.Add("goose", "geese");
            _mutatedWords.Add("mouse", "mice");
            _mutatedWords.Add("barracks", "barracks");
            _mutatedWords.Add("deer", "deer");

            //TODO: Make this configurable and be able to add new word (and its plural form)
        }
        #endregion

        public static string SplitCamelCase(string input)
        {
            // input:  TheQuickBrownFox
            // output: The Quick Brown Fox

            return Regex.Replace(input.Replace(" ", ""), "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }

        public static string ToCamelCase(this string input)
        {
            // input: the_quick_brown_fox
            // output:  TheQuickBrownFox
            return ToTitleCase(input.Replace("_", " ")).Replace(" ", "");
        }

        public static string ToFieldName(this string input)
        {
            if (input.Contains(" ")) input = input.ToCamelCase();
            
            if (Properties.Settings.Default.FieldNameCasing == "snake_case")
            {
                return ToSnakeCase(input);
            }
            return input;
        }

        public static string ToSnakeCase(this string input)
        {
            // input:  TheQuickBrownFox
            // output: the_quick_brown_fox

            if (input.Contains(" ")) input = input.ToCamelCase();
            var splitCamelCase = SplitCamelCase(input);
            return splitCamelCase.ToLower().Replace(" ", "_");
        }

        public static string ToTitleCase(this string input)
        {
            // input:  the quick brown fox
            // output: The Quick Brown Fox

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input);
        }

        public static string ToLowerFirstLetter(this string input)
        {
            // input:  TheQuickBrownFox
            // output: theQuickBrownFox

            var result = input.ToFieldName().ToCamelCase();
            var jea = System.Char.ToLowerInvariant(result[0]) + result.Substring(1);
            return jea;
        }

        public static string ToPropertyName(this string input)
        {
            // input:  theQuickBrownFox
            // output: TheQuickBrownFox

            // input:  the Quick Brown Fox
            // output: TheQuickBrownFox

            // input:  the_quick_brown_fox
            // output: TheQuickBrownFox

            return input.ToFieldName().ToCamelCase();
        }

    }
}
