namespace Krylov_Homework1_2
{
    class Buy
    {
        string name;
        float price;
        float weight;
        int number;
        float fullPrice;
        float fullWeight;

        public Buy (Product product, int number)
        {
            name = product.Name;
            price = product.Price;
            weight = product.Weight;
            this.number = number;
            fullWeight = weight * number;
            fullPrice = price * number;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public float Price
        {
            get
            {
                return price;
            }

        }
        public float Weight
        {
            get
            {
                return weight;
            }

        }
        public int Number
        {
            get
            {
                return number;
            }
        }
        public float FullPrice
        {
            get
            {
                return fullPrice;
            }
        }
        public float FullWeight
        {
            get
            {
                return fullWeight;
            }
        }

    }
}
