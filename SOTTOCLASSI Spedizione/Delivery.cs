using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    FARE OVERRIDE DI COSTO E VISUALIZZA
 */

namespace SOTTOCLASSI_Spedizione
{
    internal class Delivery
    {
        private double Weight;
        private string Adress;
        private string City;
        protected bool Delivered = false;

        public Delivery(double Weight, string Adress, string City)
        {
            this.Weight = Weight;
            this.Adress = Adress;
            this.City = City;
            Delivered = false;
        }

        public virtual double Cost () 
        {
            return 3 * Weight;
        }

        public virtual string ViewAll()
        {
            return "\nPeso: " + Weight + "kg\nCittà: " + City + "\nIndirizzo: " + Adress;
        }

        public bool HasBeenDelivered() // ritorna un valore booleano per stabilire se il pacco è stato consegnato
        {
            if (Delivered == false)
                return Delivered = true;
            else
                return false;
        }
    }
}
