using System;

namespace Lets_Pharmacy
{
    partial class Program
    {
        static void MainCUI()
        {
            Console.Clear();
            Console.WriteLine("{0}  자금: {1}", NowDate.ToString("yyyy년 MM월 dd일"), money.MyMoney);
            Console.WriteLine("직원 관리  작업 관리  회사 관리");
        }
    }
}