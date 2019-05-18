using System;

namespace Lets_Pharmacy
{
    class Material : BasicInfo
    {
        private int id;

        public int ID { get => id; set => id = value; }

        public Material(int id, string name, double price, string info)
        {
            ID = id;
            Name = name;
            Price = price;
            Info = info;
        }
    }
}
