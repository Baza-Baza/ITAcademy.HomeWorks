using System;
using System.Text;
using System.Linq;

namespace Hw_08
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int Min;
        static int max;
        static int minIndex;
        static int maxIndex;
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }


        static void Task1()
        {
            Console.WriteLine("Введите стихотворение в одну строку, отделяя ; ");
            var introducedString = Console.ReadLine();

            sb.Append(introducedString);
            sb.Replace(';', '\n');
            sb.Replace('о', 'а');

            Console.WriteLine(sb);
        }
        static void Task2()
        {

            string s1 = "Hello gys my name is nikita what about you";
            Console.WriteLine(s1);

            string[] words = s1.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < Min)
                {
                    Min = words[i].Length;
                    minIndex = i;
                }
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    maxIndex = i;
                }
            }


            do
            {
                Console.WriteLine("1 Удалить самое длинное слово\n2 Поменять местами длинное и короткое слово\n3 Подсчитать коичество знаков");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        removeWord(words);
                        break;
                    case 2:
                        ChangeWords(words);
                        break;
                    case 3:
                        CountPunctuation(words);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            } while (true);





            static string[] removeWord(string[] words)
            {
                words[maxIndex] = string.Empty;
                string DefaultString = string.Join(' ', words);
                DefaultString.Trim();
                Console.WriteLine(DefaultString);
                return words;
            }
            static string[] ChangeWords(string[] words)
            {
                string Defaultstring = words[minIndex];
                words[minIndex] = words[maxIndex];
                words[maxIndex] = Defaultstring;
                Defaultstring = string.Join(' ', words);
                Defaultstring.Trim();
                Console.WriteLine(Defaultstring);
                return words;
            }

            static int CountPunctuation(string[] words)
            {
                string Defaultstring = string.Concat(words);
                Console.WriteLine(Defaultstring.Count(char.IsPunctuation));
                return 0;
            }
        }
        static void Task3() 
        {
            sb.Append("1а!2.3!!.. 4.!.?6 7! ..?");
            Console.WriteLine(Convert.ToString(sb));
            ReplacePunctuation(); 
        }
        static void ReplacePunctuation() 
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i].Equals('?'))
                {
                    for (int j = i + 1; j < sb.Length; j++)
                    {
                        sb.Replace(' ', '_');
                    }
                }
                else 
                {
                    if (sb[i].Equals('.'))
                    {
                        sb.Remove(i, 1);
                        i--;
                    }
                    
                }
                Console.WriteLine(sb);
            }
        }
    }
}
    

