using System;
using System.Collections.Generic;

namespace Lets_Pharmacy
{
    [Serializable()]
    partial class Medicine_Data : BasicInfo
    {
        private int id;
        private bool testpass = false;

        public int Id { get => id; set => id = value; }
        public bool Testpass { get => testpass; set => testpass = value; }

        public Medicine_Data()
        {

        }

        public Medicine_Data(string name, int id, int effect, int stability, bool testpass)
        {
            Name = name;
            Id = id;
            Effect = effect;
            Stability = stability;
            Testpass = testpass;
        }
    }
}
