using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Spedizione
{
    internal class Abroad : Delivery
    {
        private string Nation;
        private double Exchange;

        public Abroad(double Weight, string Adress, string City, string Nation, double Exchange) : base(Weight, Adress, City)
        {
            this.Nation = Nation;
            this.Exchange = Exchange;
            Delivered = false;
        }

        public void SetExchange() // seleziona il valore del cambio in base alla moneta della nazione
        {
            switch (Nation)
            {
                case "yen":
                case "Yen":
                case "YEN":
                    Exchange = 116.06;
                    break;

                case "euro":
                case "Euro":
                case "EURO":
                    Exchange = 1;
                    break;

                case "dollari":
                case "Dollari":
                case "DOLLARI":
                    Exchange = 1.08;
                    break;
            }
        }
   
        public int UpdateExchange(double e) // aggiorna il valore del cambio 
        {
            if (e > Exchange)
            {
                Exchange = e;
                return 1;
            }
            else if (e < Exchange)
            {
                Exchange = e;
                return -1;
            }
            else
                return 0;
        }

        public override double Cost() // ricava il costo della spedizione moltiplicando ogni kg * 5 * il valore del cambio
        {
            return (base.Cost() / 3) * 5 * Exchange; // la divisione per 3 serve per annullare la moltiplicazione svolta nella superclasse
        }

        public override string ViewAll()
        {
            return base.ViewAll() + "\nValuta della nazione: " + Nation + "\nCambio: 1 euro = " + Exchange + " " + Nation;
        }
    }
}
