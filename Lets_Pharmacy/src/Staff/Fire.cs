using System;
using System.Collections.Generic;

namespace Lets_Pharmacy
{
    public partial class Staff_Management
    {
        public bool Fire(List<Staff> S_nothired, List<Staff> S_hired)
        {
            Console.Clear();

            Console.WriteLine("직원을 해고합니다.");
            for (int i = 1; i < S_nothired.Count + 1; i++)
            {
                Console.WriteLine(" 이름: {0}", S_nothired[i - 1].Name);
                Console.WriteLine("");
            }

            int num = 0;
            if (Controler.CursorPositionY(ref num) == false)
            {
                Console.Clear();
                Console.WriteLine("취소되었습니다.");
                Console.ReadLine();
                return false;
            }

            S_nothired.Add(S_hired[num]);
            S_hired.RemoveAt(num);

            Console.Clear();
            Console.WriteLine("{0}이 해고되었습니다.", S_hired[S_hired.Count - 1].Name);
            Console.ReadLine();
            return true;
        }
    }
}