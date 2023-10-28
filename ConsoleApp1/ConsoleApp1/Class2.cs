using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delight_Chipiro_PRG2X1_CT1

{
    public class Rectangle : Shapes
    {
        public void captureDetails()
        {
            Console.WriteLine("Calculating the Area of a Rectangle");
            Console.WriteLine("");
            Console.WriteLine("Enter base of rectangle");
            baseValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of rectangle");
            height = double.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = baseValue * height;
        }
        public void PrintDetails()
        {
            
            Console.WriteLine("Area of Rectangle is " + area);

        }
    }
}
