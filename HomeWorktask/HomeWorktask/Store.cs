using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorktask
{
    internal class Store
    {
        Product[] Products=new Product[0];

        public void AddProduct(Product pr)
        {
            if (!HasProductByNo(pr.No))
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = pr;
            }
            else
            {
                throw new SameProductName($"Sizin burda: {Products} qeyd etdiyiniz mehsul artiq var");
            }
        }
        public bool HasProductByNo(int no)
        {
            foreach(Product item in Products)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }
        public Product GetProductByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No==no)
                {
                    return Products[i];
                }
            }
            throw new SameProductName($"{no} li mehsul yoxdur");
        }
    }
}
