using System;

namespace Krylov_Homework1_2
{
    class Product
    {
        string name;
        float price;
        float weight;

        public Product(string name, float price, float weight)
        {
            if (price < 0 || weight <= 0)
                throw new ArgumentException();
            this.name = name;
            this.price = price;
            this.weight = weight;
        }
        public Product()
        {
            name = "None";
            price = 0;
            weight = 0;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                    this.price = value;
            }
        }
        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                this.weight = value;
            }
        }
        public virtual void ChangePrice(float percent)
        {
            Price += Price * (percent / 100);
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}.";
        }
    }
}
