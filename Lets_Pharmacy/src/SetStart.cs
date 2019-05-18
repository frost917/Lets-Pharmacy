using System;

namespace Lets_Pharmacy
{
    partial class Program
    {
        static void SetStart()
        {
            Console.Write("이름 입력: ");
            Hired.Add(new Staff(Console.ReadLine(), 10, 10, 10, 10, 0, 0, "주인공."));
        }
    }
}