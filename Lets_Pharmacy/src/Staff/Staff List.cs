using System;
using System.Collections.Generic;

namespace Lets_Pharmacy
{
    partial class Program
    {
        private static List<Staff> nothired = new List<Staff>
        {
            new Staff("고길동", 10, 10, 10, 0, 50, 10, "Only For Test")
        };
        private static List<Staff> hired = new List<Staff>();

        public static List<Staff> Hired => hired;
        public static List<Staff> Nothired => nothired;
    }
}