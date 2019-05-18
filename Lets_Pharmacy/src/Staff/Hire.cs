using System;
using System.Collections.Generic;

namespace Lets_Pharmacy
{
    public partial class Staff_Management
    {
        public bool Hire(List<Staff> S_nothired, List<Staff> S_hired)
        {
            Console.Clear();

            Console.WriteLine("직원을 고용합니다.");
            for (int i = 1; i < S_nothired.Count + 1; i++)
            {
                Console.WriteLine(" 이름: {0}, 체력: {1}, 약효: {2}, 안정성: {3}, 계약금: {4}, 월급: {5}",
                                  S_nothired[i - 1].Name,
                                  S_nothired[i - 1].Hp,
                                  S_nothired[i - 1].Effect,
                                  S_nothired[i - 1].Stability,
                                  S_nothired[i - 1].Price,
                                  S_nothired[i - 1].Salary);
                Console.WriteLine("정보: {0}", S_nothired[i - 1].Info);
                Console.WriteLine("");
            }

            int num = 0;
            if(Controler.CursorPositionY(ref num) == false)
            {
                Console.Clear();
                Console.WriteLine("취소되었습니다.");
                Console.ReadLine();
                return false;
            }

            S_hired.Add(S_nothired[num]);
            S_nothired.RemoveAt(num);

            Console.Clear();
            Console.WriteLine("{0}이 고용되었습니다.", S_hired[S_hired.Count - 1].Name);
            Console.ReadLine();
            return true;
        }
    }

}