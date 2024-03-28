using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_14
{
    internal class Product
    {
        public int Id;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int InCome;
        public int Count;

        public Product(int id,string brandName,string model,int price,int cost,int count)
        {
            Id = id;
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            InCome = 0;
          
            if (count>0)
            {
            Count = count;
            }else Count= 0;
            if (Count > 0)
            {
                InCome += (Price - Cost);
                Count--;
                Console.WriteLine("Id--BrandName--Model--Price--Cost--Income--Count");
                Console.WriteLine(Id + " " + BrandName + " " + Model + " " + Price + " " + Cost + " " + InCome + " " + Count);
            }
            else
            {
                Console.WriteLine("Mehsul bitib");
            }
        }

        public void GetInfo(Product product)
        {
            Console.WriteLine("Id--BrandName--Model--Price--Cost--Income--Count");
          Console.WriteLine(product.Id+" "+product.BrandName+" "+product.Model+" "+product.Price+" "+product.Cost+" "+product.InCome+" "+Count);
        }

    

    }
}
