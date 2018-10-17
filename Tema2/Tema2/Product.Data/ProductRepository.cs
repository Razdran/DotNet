using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Data
{
    class ProductRepository
    {
        List<Product> productList = new List<Product>();
        
        public ProductRepository()
        {
            Product prod1 = new Product();
            Product prod2 = new Product();
            Product prod3 = new Product();
            productList.Add(prod1);
            productList.Add(prod2);
            productList.Add(prod3);
        }
        public Product GetPoductByName(string productName)
        {
            foreach(Product i in productList)
            {
                if (i.Name.Equals(productName))
                    return i;
            }
            return null;
        }
        public List<Product> FindAllProducts()
        {
            return productList;
        }
        public void  AddProduct(Product product)
        {
            productList.Add(product);
        }
        public Product GetProductByPosition(int position)
        {
            int nr = 0;
            
            if(position<0||position > productList.Count-1)
                return null;
            else
                foreach (Product i in productList)
                {

                    if (nr == position)
                        return i;
                    nr++;
                }
            return null;
        }

        public void RemoveProductByName(string productName)
        {
            int nr = 0, ok = 0; ;
            
            foreach (Product i in productList)
            {
                if (i.Name.Equals(productName))
                {
                    productList.RemoveAt(nr);
                    ok = 1;
                }
                nr++;
            }
            if (ok == 0)
            {
                Console.WriteLine("No such product");
            }
            
        }


    }
}
