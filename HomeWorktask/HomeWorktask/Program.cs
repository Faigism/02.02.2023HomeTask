using System;
using System.ComponentModel;

namespace HomeWorktask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store prdct = new Store();

            Product pr1 = new Product()
            {
                Category = "Un Memulatlari",
                No = 1,
                Price = 100
            };
            Product pr2 = new Product()
            {
                Category = "Et Mehsullari",
                No = 2,
                Price = 500
            };
            Product pr3 = new Product()
            {
                Category = "Ickiler",
                No = 3,
                Price = 1000
            };

            try
            {
                prdct.AddProduct(pr1);
                prdct.AddProduct(pr2);
                prdct.AddProduct(pr3);
                prdct.AddProduct(pr3);
            }
            catch (SameProductName ex)
            {
                Console.WriteLine("Eyni adli mehsul artiq var.." + ex.Message);
            }
            Console.WriteLine(prdct);
        }
    }
}
