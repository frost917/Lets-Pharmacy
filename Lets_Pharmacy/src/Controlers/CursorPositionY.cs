using System;

namespace Lets_Pharmacy
{
    public static partial class Controler
    {
        public static bool CursorPositionY(ref int num)
        {
            num = 0;
            ConsoleKeyInfo select;
            int x = 0, y = 1;
            Console.SetCursorPosition(x, y);

            do
            {
                select = Console.ReadKey();
                switch (select.Key)
                {
                    case ConsoleKey.UpArrow:
                    {
                        if (y != 1)
                        {
                            y -= 3;
                            num++;
                        }
                        break;
                    }
                    case ConsoleKey.DownArrow:
                    {
                        if (y < 100)
                        {
                            y += 3;
                            num--;
                        }
                        break;
                    }
                    case ConsoleKey.Escape:
                    {
                        return false;
                    }
                    default:
                        break;
                }
                Console.SetCursorPosition(x, y);
            } while (select.Key != ConsoleKey.Enter);
            Console.Clear();
            return true;
        }
    }
}