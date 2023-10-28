using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delight_Chipiro_PRG2X1_CT1
{
    class Program
    {
        enum menu
        {
            Rectangle = 1,
            Triangle = 2,
            Circle = 3,
            Exit = 4,
        }
        static void Main(string[] args)
        {
            bool Continue = true;

            while (Continue)
            {
                Console.WriteLine("CALCULATE AREA");
                Console.WriteLine("");
                Console.WriteLine("1......Rectangle");
                Console.WriteLine("");
                Console.WriteLine("2.....Triangle");
                Console.WriteLine("");
                Console.WriteLine("3.....Circle");
                Console.WriteLine("");
                Console.WriteLine("4.....Exit");
                Console.WriteLine("");
                Console.WriteLine("Select your choice:");
                int choice = int.Parse(Console.ReadLine()); 
                switch ((menu)choice)
                {
                    case menu.Rectangle:
                        Console.Clear();
                        Rectangle rectangle = new Rectangle();
                        rectangle.captureDetails();
                        rectangle.CalculateArea();
                        rectangle.PrintDetails();

                        break;
                    case menu.Triangle:
                        Console.Clear();
                        Triangle triangle = new Triangle();
                        triangle.captureDetails();
                        triangle.CalculateArea();
                        triangle.PrintDetails();

                        break;
                    case menu.Circle:
                        Console.Clear();
                        Circle circle = new Circle();
                        circle.captureDetails();
                        circle.CalculateArea();
                        circle.PrintDetails();
                        break;


                    case menu.Exit:
                        Console.WriteLine("Thank you for using this program");
                        Console.WriteLine("Press Enter to exit");
                        Continue = false;
                        break;

                }
            }

        }
    }
}
