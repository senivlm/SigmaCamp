using System;

namespace Krylov_Homework1_2
{
    static class Check
    {
        static public void ShowProductInfo(Product product)
        {
            Console.WriteLine("Product name: " + product.Name);
            Console.WriteLine("Product price: " + product.Price + " grn");
            Console.WriteLine("Product weight: " + product.Weight + " kg");

        }
        static public void ShowProductInfo(Meat product)
        {
            Check.ShowProductInfo((Product)product);
            Console.WriteLine("Product cat: " + product.Cat);

        }
        static public void ShowBuyInfo(Buy product)
        {
            Console.WriteLine("You buy " + product.Name + " x" + product.Number);
            Console.WriteLine("Full price is " + product.FullPrice + " grn");
            Console.WriteLine("Full weight is " + product.FullWeight + " kg");
        }
    }
}
