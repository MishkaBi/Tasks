using System;

namespace Hello_Misha
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello Misha";
            Console.WriteLine(phrase);
            char[] letters = phrase.ToCharArray();
            for (int i = 6; i < letters.Length; i++)
            {
                Console.WriteLine(char.ToUpper(letters[i]));
            }
        }
    }
}
