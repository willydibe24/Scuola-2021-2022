using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Di_Bella_Maggio_2022
{
    internal class BusAgency
    {
        protected string Model;
        protected int Year; // anno di acquisto
        protected int Seats; // numero di posti
        protected double TicketCost;
        public int KilometersTraveled { get; set; } = 0; // progressivo km percorsi
        public int EmittedTickets { get; set; } = 0; // progressivo numero biglietti


        public BusAgency (string Model, int Year, int Seats, double TicketCost)
        {
            this.Model = Model;
            this.Year = Year;
            this.Seats = Seats;
            this.TicketCost = TicketCost;
        }

        public string EndOfTheDay(int km, int t)
        {
            KilometersTraveled += km;
            EmittedTickets += t;

            return "\nKM percorsi: " + KilometersTraveled + "\nBiglietti complessivi emessi: " + EmittedTickets;
        }

        public virtual double TotalEarning()
        {
            return TicketCost * EmittedTickets;
        }

        public double AnnualEarning (int currentyear)
        {
            return EmittedTickets / (currentyear - Year) * TicketCost; // anno corrente - anno di acquisto * 365 * biglietti emessi al giorno * costo di un biglietto
        }

        public double ChangeCost (double percentage)
        {
            return TicketCost -= (TicketCost * percentage) / 100;
        }

        public virtual string ViewAll()
        {
            return "\nModello: " + Model + "\nAnno di acquisto: " + Year + "\nNumero di posti: " + Seats + "\nCosto di 1 biglietto: " + TicketCost;
        }
    }
}
