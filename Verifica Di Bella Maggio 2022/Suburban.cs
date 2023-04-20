using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Di_Bella_Maggio_2022
{
    internal class Suburban : BusAgency
    {
        private int Cities; // numero di comuni sul percorso
        private bool SummerTransport;

        public Suburban (string Model, int Year, int Seats, double TicketCost, int Cities, bool SummerTransport) : base (Model, Year, Seats, TicketCost)
        {
            this.Cities = Cities;
            this.SummerTransport = SummerTransport;

        }

        public override double TotalEarning()
        {
            if (Cities > 2)
                return base.TotalEarning() * 2;
            else
                return base.TotalEarning();
        }

        public bool SetSummer()
        {
            if (SummerTransport == false)
                return SummerTransport = true;
            else
                return SummerTransport = false;
        }

        public override string ViewAll()
        {
            if (SummerTransport == true)
                return base.ViewAll() + "\nSOLO ESTIVO";
            else
                return base.ViewAll();
        }

        /* public int CheckRevisions() // domanda 3
        {
            if (KilometersTraveled % 25 == 0 && Revisions < 20)
                Revisions++;
            return Revisions;
        }
        */
    }
}
