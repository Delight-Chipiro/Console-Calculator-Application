using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delight_Chipiro_PRG2X1_CT1
{
    public class Circle : Shapes
    {
        public double pi = 3.142857143;
        public void captureDetails()
        {
            Console.WriteLine("Calculating the Area of a Circle");
            Console.WriteLine("");
            Console.WriteLine("Enter Radius of Circle");
            height = double.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {

            area = pi * (height * height);
        }
        public void PrintDetails()
        {
            
            Console.WriteLine("Area of Circle is " + area);
        }


    }
}
