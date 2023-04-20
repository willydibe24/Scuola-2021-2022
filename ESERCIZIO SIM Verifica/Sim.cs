using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_SIM_Verifica
{
    internal class Sim
    {
        protected string phoneNumber;
        protected string phoneCompany;
        protected double credit;
        protected int phoneCalls { get; set; } = 0;
        protected int duration { get; set; } = 0;


        public Sim (string phoneNumber, string phoneCompany, double credit)
        {
            this.phoneNumber = phoneNumber;
            this.phoneCompany = phoneCompany;
            this.credit = credit;
        }

        public string NewPhoneCall(int duration)
        {
            if (credit - 0.20 - ((duration / 30) * 0.30) <= 0)
                return "\nCredito residuo insufficiente";

            credit -= 0.20 - ((duration / 30) * 0.30);
            this.duration += duration;
            phoneCalls++;

            return "\nChiamata effettuata correttamente";
        }

        public double TrafficImport()
        {
            return phoneCalls * 0.20 + ((duration / 30) * 0.30);
        }
    }
}
