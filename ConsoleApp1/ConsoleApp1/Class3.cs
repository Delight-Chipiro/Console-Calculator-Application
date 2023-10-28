using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delight_Chipiro_PRG2X1_CT1
{
    public class Triangle : Shapes
    {
        public void captureDetails()
        {
            Console.WriteLine("Calculating the Area of a Triangle");
            Console.WriteLine("");
            Console.WriteLine("Enter base of Triangle");
            baseValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of Triangle");
            height = double.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = 0.5 * (baseValue * height);
        }
        public void PrintDetails()
        {
            
            Console.WriteLine("Area of Triangle is " + area);

        }
    }
}
