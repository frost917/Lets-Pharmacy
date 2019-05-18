using System;

namespace Lets_Pharmacy
{
    public static partial class Controler
    {
        public static bool CursorPositionX(ref int num)
        {
            num = 0;
            ConsoleKeyInfo select;
            int x = 3, y = 1;
            Console.SetCursorPosition(x, y);

            do
            {
                select = Console.ReadKey();
                switch (select.Key)
                {
                    case ConsoleKey.RightArrow:
                    {
                        if (x != 50)
                        {
                            x += 12;
                            num++;
                        }
                        break;
                    }
                    case ConsoleKey.LeftArrow:
                    {
                        if (x != 2)
                        {
                            x -= 12;
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
