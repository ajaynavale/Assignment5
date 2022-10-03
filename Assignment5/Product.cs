using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Product
    {
        private int id, price,dis;
        private string name;
        private int discount;

        public void GetData(int id,string name,int price,int discount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discount = discount;
        }
        public void Calculate()
        {
            price = price - (price * discount / 100);
        }
        public string display()
        {
            return $"{name} Price:{price} ";
        }
    }
}
