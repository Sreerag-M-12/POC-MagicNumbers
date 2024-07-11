using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static float PI = 3.14f;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius");
            float radius = Convert.ToSingle(Console.ReadLine());
            float circleArea = PI * radius * radius;
            float SphereVolume = PI * radius * radius * radius;
            Console.WriteLine("area of circle is " + circleArea + " squnits");
            Console.WriteLine("volume of sphere is " + SphereVolume + " squnits");





        }

    }

}

