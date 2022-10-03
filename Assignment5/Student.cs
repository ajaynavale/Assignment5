using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Student
    {
        private int no;
        private string name;
        private int su1, su2, su3, total;
        private double percentage;
        public void AddValues(int a, string b, int c, int d, int e)
        {
            no = a;
            name = b;
            su1 = c;
            su2 = d;
            su3 = e;
        }
        public void Calculate()
        {
            total = su1 + su2 + su3;
            percentage = (double)total / 3;
        }
        public string GetValues()
        {
            return $"Roll no:{no}\nName:{name}\nTotal is:{total}  percentage is:{percentage}";
        }
    }
}