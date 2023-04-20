using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTOCLASSI_Rettangolo
{
    internal class Parallelogram
    {
        protected double Side1, Side2; //lato1, lato2
        public bool RightAngle{ get; set; } //angoloretto

        //metodo per il calcolo del perimetro
        public double GetPerimeter()
        {
            return (Side1 + Side2) * 2;
        }

        public string Description()
        {
            if (RightAngle == true)
                return "il parallelogramma è un rettangolo";

            else
                return "il parallelogramma non è un rettangolo";
        }
    }
}
