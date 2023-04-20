using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Conto_corrente_con_vettore
{
    class BankAccount
    {
        private string[] AccountHolder = new string [100]; //correntista
        private string[] AccountNumber = new string[100]; //numeroconto
        private double[] Balance = new double[100]; //saldo
        int n;

        public BankAccount()
        {
            n = 0;
        }

        public void LoadData (string AccountHolder, string AccountName, double Balance)
        {
            this.AccountHolder[n] = AccountHolder;
            this.AccountNumber[n] = AccountName;
            this.Balance[n] = Balance;
            n++;
        }

        public string GetAccountHolder(int i)
        { 
            return AccountHolder[i];
        }

        public string GetAccountNumber(int i)
        {
            return AccountNumber[i]; 
        }

        public double GetBalance(int i)
        {
            return Balance[i];
        }
        public int Withdrawal (double withdrawal, int i) //prelievo
        {
            if (Balance[i] > 0 && Balance[i] >= withdrawal)
            {
                Balance[i] = (double)Balance[i] - withdrawal;
                return 1;
            }
            else
                return 0;
        }

        public bool Deposit (double deposit, int i)
        {
            if (deposit > 0)
            {
                Balance[i] = Balance[i] + deposit;
                return true;
            }
            else
                return false;
        }

        //autenticazione
        public int Authentication (string AccountHolder, string AccountNumber)
        {
            int found = -1;
            for (int i = 0; i < n ; i++)
            {
                if (this.AccountHolder[i] == AccountHolder && this.AccountNumber[i] == AccountNumber)
                    found = i;
            }
            return found;
        }
    }
}
