using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Vehicle
    
        {
    public string brand;
        public string model;
        public double mile;
        public Vehicle(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public void showfullname()
        {
            Console.WriteLine($"brand:{brand},model:{model}");
        }
    }
}
