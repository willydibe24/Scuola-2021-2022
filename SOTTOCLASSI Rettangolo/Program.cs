using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTOCLASSI_Rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Side1, Side2;
            int scelta;
            Console.WriteLine("Inserire il primo lato: ");
            Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il secondo lato: ");
            Side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(Side1, Side2);

            Console.WriteLine("Scegli il tipo di figura:\n1)Parallelogramma\n2)Rettangolo");
            scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                rectangle.RightAngle = false;
                Console.WriteLine(rectangle.Description());
            }

            else
            {
                rectangle.RightAngle = true;
                Console.WriteLine(rectangle.Description());
                Console.WriteLine("Il perimetro vale: " + rectangle.GetPerimeter());
                Console.WriteLine("L'area vale: " + rectangle.GetArea()); 
            }

            Console.ReadKey();
        }
    }
}
