using System;

namespace Lets_Pharmacy
{
    [Serializable()]
    public partial class Staff : BasicInfo
    {
        private int hp, sanity;
        private double salary;

        public int Hp { get => hp; set => hp = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Sanity { get => sanity; set => sanity = value; }

        public Staff()
        {

        }

        public Staff(string name, int hp, int effect, int stability, int sanity, double price, double salary, string info)
        {
            Name = name;
            Effect = effect;
            Price = price;
            Info = info;
            Stability = stability;
            this.hp = hp;
            this.sanity = sanity;
            this.salary = salary;
        }
    }
}
