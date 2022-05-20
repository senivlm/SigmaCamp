using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krylov_Homework1_2
{
    class Dairy_Products : Product
    {
        int expiration_Date = 0;
        readonly float[] storagePercent = { 10, 9, 8,7,6,5,4,3,2,1, };

        public Dairy_Products(string name, float price, float weight, int days) : base(name, price, weight)
        {
            Expiration_Date = days;
        }
        public float[] StoragePercent => storagePercent;

        public int Expiration_Date { 
            get => expiration_Date;
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                else
                    expiration_Date = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}, Expired in {Expiration_Date} days.";
        }
        public override void ChangePrice(float percent)
        {
            if (expiration_Date <= 9)
            {
                Price += (Price * (percent / 100)) + Price * (StoragePercent[expiration_Date] / 100);

            }
            else
            {
                Price += Price * (percent / 100);
            }
        }
    }
}
