using System.Text;

namespace Algorithms.Test.CamelCase
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            if (str == null || str.Length == 0)
                return str;

            StringBuilder camelCase = new();
            str = str.Replace("_", "-");
            str = str.Trim('-');

            string[] words = str.Split("-");

            if (words.Length == 0)
                return string.Empty;

            if (words[0].Length > 0)
            {
                camelCase.Append(words[0][0]);
                camelCase.Append(words[0].Substring(1).ToLower());
            }

            if (words.Length == 1)
                return camelCase.ToString();

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                    continue;

                camelCase.Append(char.ToUpper(words[i][0]));
                camelCase.Append(words[i].Substring(1).ToLower());
            }

            return camelCase.ToString();
        }
    }
}