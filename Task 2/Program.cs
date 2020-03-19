using System;

namespace Task_2
{
    class Program
    {
        public static void mapRender(char[,] map) //Очищает и рендерит карту;
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            int heroX = 3; 
            int heroY = 2;

            char[,] map =
            {
                {'#','#','#','#','#','#','#'},
                {'#','.','.','.','.','.','#'},
                {'#','.','.','.','.','.','#'},
                {'#','.','.','.','.','.','#'},
                {'#','#','#','#','#','#','#'}
            };

            map[heroY, heroX] = '@'; 

            mapRender(map); 

            ConsoleKeyInfo keypress;
            do
            {
                keypress = Console.ReadKey();

                if (keypress.KeyChar == 'w') 
                {
                    if (map[heroY - 1, heroX] != '#') 
                    {
                        map[heroY, heroX] = '.';
                        map[heroY - 1, heroX] = '@';
                        heroY--;
                        mapRender(map);
                    }
                    else mapRender(map);
                }

                if (keypress.KeyChar == 'd') 
                {
                    if (map[heroY, heroX + 1] != '#')
                    {
                        map[heroY, heroX] = '.';
                        map[heroY, heroX + 1] = '@';
                        heroX++;
                        mapRender(map);
                    }
                    else mapRender(map);
                }

                if (keypress.KeyChar == 's')  
                {
                    if (map[heroY + 1, heroX] != '#')
                    {
                        map[heroY, heroX] = '.';
                        map[heroY + 1, heroX] = '@';
                        heroY++;
                        mapRender(map);
                    }
                    else mapRender(map);
                }

                if (keypress.KeyChar == 'a')  
                {
                    if (map[heroY, heroX - 1] != '#')
                    {
                        map[heroY, heroX] = '.';
                        map[heroY, heroX - 1] = '@';
                        heroX--;
                        mapRender(map);
                    }
                    else mapRender(map);
                }

            } while (keypress.KeyChar != 'Q');
        }
    }
}
