namespace Krylov_Homework1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var milk = new Dairy_Products("Milk", 30f, 1,1);
            var pork = new Meat("Pork", 30.5f, 1, Meat.Catagory.FirstSort, Meat.KindOf.Pork);
            Product[] products= {milk,pork};
            var Busket = new Storage(products);
            Busket.ShowInfo();
            Busket.ChangePrice(10);
            Busket.ShowInfo();

            //var chicken = new Meat("Chicken", 30.5f, 1, 2,3);
            //var buyMilk = new Buy(milk, 15);

            //Check.ShowProductInfo(chicken);
            //Console.WriteLine(chicken.Cat);
            //Check.ShowBuyInfo(buyMilk);

        }
    }
}
/*Розробити 3 класи:
клас Product, який має три елемент-даних – назва, ціна і вага  
клас Buy, містить дані про товар, кількість товару, що купується в штуках, про ціну за весь куплений товар і про вагу товару 
клас Check, що не містить ніяких елементів-даних. Даний клас повинен виводити на екран інформацію про товар і про покупку;
Створити конструктори класів, визначити властивості з різними модифікаторами.
Продемонструвати створення екземплярів класів.
*/