using System;

namespace Hm_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 25; i < letters.Length; i--)
                Console.WriteLine(letters[i]);
        }
    }
}
