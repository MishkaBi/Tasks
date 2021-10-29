using System;

namespace Hello_Misha
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello Misha";
            Console.WriteLine(phrase);
            string[] words = phrase.Split(" ");
            char[] lastWord = words[words.Length - 1].ToCharArray();
            for (int i = 0; i < lastWord.Length; i++)
            {
                Console.WriteLine(char.ToUpper(lastWord[i]));
            }
        }
    }
}
