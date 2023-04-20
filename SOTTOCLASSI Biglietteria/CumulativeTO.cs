using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Biglietteria
{
    internal class CumulativeTO : TicketOffice
    {
        private double Discount { get; set; }
        private int PeopleNumber { get; set; }

        public CumulativeTO (string Code, string Name, int TicketNumber, double Price, double Discount, int PeopleNumber)
        {
            this.Code = Code;
            this.Name = Name;
            this.TicketNumber = TicketNumber;
            this.Price = Price;
            this.Discount = Discount;
            this.PeopleNumber = PeopleNumber;
        }

        public double AddDiscount ()
        {
            if (PeopleNumber >= 10)
            {
                Discount = (10 * Price) /100;
                return Math.Round((Price -= Discount), 2);
            }
            else
            {
                Discount = (5 * Price) / 100;
                return Math.Round((Price -= Discount), 2);
            }
        }
    }
}
