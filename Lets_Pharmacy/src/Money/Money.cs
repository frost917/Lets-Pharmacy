using System;
using System.Collections.Generic;
using System.Text;

namespace Lets_Pharmacy
{
    class Money_Data
    {
        private int invest, finalInvest;
        private double myMoney;
        private double income, outcome;

        public Money_Data()
        {
            myMoney = 1000;
            income = 0;
            outcome = 0;
        }

        public int Invest { get => invest; set => invest = value; }
        public int FinalInvest { get => finalInvest; set => finalInvest = value; }
        public double MyMoney { get => myMoney; set => myMoney = value; }
        public double Income { get => income; set => income = value; }
        public double Outcome { get => outcome; set => outcome = value; }
    }
}
