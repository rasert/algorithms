namespace Algorithms.Test.StopSpinningMyWords
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                int len = words[i].Length;

                if (len < 5)
                    continue;

                // Reverse string
                for (int j = 0, k = len -1; j < len / 2; j++, k--)
                {
                    char aux = word[j];
                    word[j] = word[k];
                    word[k] = aux;
                }

                words[i] = new string(word);
            }

            return string.Join(" ", words);
        }
    }
}
