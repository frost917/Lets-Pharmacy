using System;

namespace Lets_Pharmacy
{
    partial class Program
    {
        static void Sleeping(ref DateTime NowDate)
        {
            int DicKey = 0;
            if(NowDate.Hour < 18)
            {
                DicKey = 1;
            }
            else if(NowDate.Hour > 20)
            {
                DicKey = 2;
            }

            Scripts.SleepScript.TryGetValue(DicKey, out string value);
            Console.WriteLine(value);
            Console.WriteLine("내일은 부디 평범한 하루이길 빌며 잠에 들었다.");

            NowDate = NowDate.AddDays(1);
        }
    }
}