using System;
using System.Collections.Generic;
using System.Text;

namespace Lets_Pharmacy
{
    partial class Medicine_Calculator : Medicine_Data
    {
        public void Making(List<Staff> Hired)
        {
            for (int i = 0; i < Hired.Count; i++)
            {
                Random rand1 = new Random();
                Random rand2 = new Random();

                Effect += Hired[i].Effect * rand1.Next(-1, 1);
                Stability += Hired[i].Stability * rand2.Next(-1, 1);
            }
        }

        public void SetTestPass(Medicine_Data med)
        {
            double TestingValue = Effect % Stability;

            if (TestingValue < 10)
            {
                Console.WriteLine("임상실험에 성공했다.");
                med.Testpass = true;
            }
            else
            {
                Console.WriteLine("임상실험에 실패했다.");
                TestFailed();
                med.Testpass = false;
            }
        }

        private void TestFailed()
        {
            Random random = new Random();
            int randvalue = random.Next(0, Scripts.FailedScript.Count);

            Scripts.FailedScript.TryGetValue(randvalue, out string value);
            Console.WriteLine(value);

            for (int i = 1; i < Program.Hired.Count; i++)
            {
                Program.Hired[i].Sanity--;
            }
        }
    }
}
