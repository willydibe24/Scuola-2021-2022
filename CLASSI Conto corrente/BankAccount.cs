using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Conto_corrente
{
    internal class BankAccount
    {
        private string AccountHolder; //correntista
        private string AccountNumber =  "abc123"; //numeroconto
        private double balance; //saldo

        public BankAccount (string AccountHolder) //costruttore
        {
            this.AccountHolder = AccountHolder;
            balance = 0;
        }

        //metodi
        public string GetAccountHolder() 
        {
            return AccountHolder;
        }

        //proprietà
        public string GetAccountNumber
        {
            get { return AccountNumber; }
        }

        public double GetSetBalance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Withdrawal (double withdrawal)
        {
            if (balance > 0 && balance < withdrawal)
            {
                balance = (double) balance - withdrawal;
                return 1;
            }
            else
                return 0;
        }

        public bool Deposit (double deposit)
        {
            if (deposit > 0)
            {
                balance = balance + deposit;
                return true;
            }
            else
                return false;
        }

        //autenticazione
        public bool Authentication (string AcconutHolder, string AccountNumber)
        {
            if (this.AccountHolder == AcconutHolder && this.AccountNumber == AccountNumber)
                return true;
            else
                return false;
        }
    }
}
