using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krylov_Homework1_2
{
    class Storage
    {
        private Product[] products;
        //Конструктор без параметрів
        public Storage(params Product[] products)
        {
            this.products = products;
        }
        //Небажаний метод
        public void ShowInfo()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
        public void FindMeat()
        {
            for (int i = 0; i < products.Length; i++)
            {//операції is as!!!
                if (products[i].GetType() == typeof(Meat))
                    Console.WriteLine(products[i]);
            }
        }
        public void ChangePrice(float percent)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].Price += products[i].Price * (percent / 100);
            }
            
        }
    }
}
