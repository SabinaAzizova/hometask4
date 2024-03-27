using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car:Vehicle
    {
        public int doorsNum;
        public Car(string brand, string model) : base(brand, model)
        {

        }
        public void showfullname()
        {
            Console.WriteLine($"brand:{brand},model:{model}");
        }

    }
    

    }
