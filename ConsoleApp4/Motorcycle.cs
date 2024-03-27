using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Motorcycle : Vehicle
    {
        public int WheelNum;
        public Motorcycle(string brand, string model) : base(brand, model)
        {

        }
        public void showfullname()
        {
            Console.WriteLine($"brand:{brand},model:{model}");
        }
    }
}

