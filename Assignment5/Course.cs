using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Course
    {
        private int id;
        private string name;
        private double fee;

        public void AddValues(int d,string n,double f)
        {
            id = d;
            name = n;
            fee = f;
        }
        public string GetValues()
        {
            return $"id:{id}\nCourse name:{name}\nfees:{fee}";
        }
    }
}
