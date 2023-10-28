using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delight_Chipiro_PRG2X1_CT1
{

    public class Shapes
    {
        public double area;
        public double baseValue;
        public double height;

        public void Shape()
        {
            Console.WriteLine("Calculating the Areas of different shapes");
        }
        public virtual void CalculateArea()
        {
        }
    }
}
