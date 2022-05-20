using System;

namespace Krylov_Homework1_2
{
    class Meat : Product
    {
        public enum Catagory { HighSort, FirstSort, SecondSort }
        public enum KindOf { Mutton, Veal, Pork, Chicken }
        readonly float[] storagePercent = { 5, 3, 2 };
        Catagory cat;
        KindOf kind;
        public Meat(string name, float price, float weight) : base(name, price, weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }
        public Meat(string name, float price, float weight, int cat, int kind) : base(name, price, weight)
        {
            Cat = (Catagory)Enum.GetValues(typeof(Catagory)).GetValue(cat - 1);
            Kind = (KindOf)Enum.GetValues(typeof(KindOf)).GetValue(kind - 1);
        }
        public Meat(string name, float price, float weight, Catagory cat, KindOf kind) : base(name, price, weight)
        {
            Cat = cat;
            Kind = kind;
        }
        public Catagory Cat
        {
            get
            {
                return cat;
            }
            set
            {
                cat = value;
            }
        }

        internal KindOf Kind { get => kind; set => kind = value; }

        public float[] StoragePercent => storagePercent;

        public override void ChangePrice(float percent)
        {
            Price += (Price * (percent / 100)) + Price * (StoragePercent[(int)Cat] / 100);
        }
    }
}
