using System;

namespace Lets_Pharmacy
{
    [Serializable()]
    public class BasicInfo
    {
        private string name;
        private string info;
        private double price;
        private int effect;
        private int stability;

        public string Name { get => name; set => name = value; }
        public string Info { get => info; set => info = value; }
        public double Price { get => price; set => price = value; }
        public int Effect { get => effect; set => effect = value; }
        public int Stability { get => stability; set => stability = value; }
    }
}
