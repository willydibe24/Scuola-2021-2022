using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Biglietteria
{
    internal class TicketOffice
    {
        protected string Code { get; set; } //codice identificativo della macchinetta
        protected string Name { get; set; } //nome della fermata del bus   
        protected int TicketNumber { get; set; } //numero di biglietti ancora disponibili
        protected double Price { get; set; } //prezzo del biglietto
        protected bool Status { get; set; } = true; //stato macchinetta
        public int GetTicketNumber() { return TicketNumber; } //ritorna il numero di biglietti

        public int Refill (int n)
        {
            TicketNumber += n;
            Status = true;
            return TicketNumber;
        }

        public double Sell (int n)
        {
            if (Status != false)
            {
                if (TicketNumber >= n)
                {
                    TicketNumber -= n;
                    return Price * n;
                }
                else
                {
                    return 0;
                }
            }
            else
                return 0;
        }

        public string Repair ()
        {
            if (Status == false)
            {
                Status = true;
                return "\nMacchinetta operativa";
            }
            else
            {
                Status = false;
                return "\nMacchinetta in manutenzione";
            }
        }     
    }
}
