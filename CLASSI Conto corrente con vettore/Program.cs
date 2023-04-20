using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Conto_corrente_con_vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTIONE CONTO CORRENTE");

            int n, option, found;
            string name, num, compare_name, compare_num;
            double balance;

            BankAccount BAccount = new BankAccount();
            
            do
            {
                Console.WriteLine("\nInserire il numero di utenti: ");
                n = int.Parse(Console.ReadLine());
            } while (n > 100);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserire il nome del " + (i + 1) + "° correntista: ");
                name = Console.ReadLine();
                Console.WriteLine("Inserire il numero di conto del correntista " + name + ": ");
                num = Console.ReadLine();
                Console.WriteLine("Inserire il saldo del correntista " + name + ": ");
                balance = double.Parse(Console.ReadLine());

                BAccount.LoadData(name, num, balance);
            }

            do
            {
                Console.WriteLine("\nAUTENTICAZIONE");
                Console.WriteLine("\nInserire il nome: ");
                compare_name = Console.ReadLine();
                Console.WriteLine("Inserire il numero di conto di " + compare_name + ": ");
                compare_num = Console.ReadLine();

                found = BAccount.Authentication(compare_name, compare_num);

                if (found >= 0)
                    Console.WriteLine("\nAutenticazione riuscita!");
                else
                    Console.WriteLine("\nAutenticazione fallita! Riprova");
            } while (found == -1);

            do
            {
                Console.WriteLine("\nMENU\n\n1)Effettua un prelievo\n2)Effettua un deposito\n3)Visualizza le informazioni del correntista\n0)Esci");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Il programma verrà chiuso");
                        break;

                    case 1:
                        double withdrawal, wl;
                        Console.WriteLine("Inserire la quantità di denaro da prelevare: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        wl = BAccount.Withdrawal(withdrawal, found);
                        if (wl == 1)
                            Console.WriteLine("Prelievo riuscito!");
                        else
                            Console.WriteLine("Prelievo non riuscito!");
                        break;

                    case 2:
                        double deposit;
                        Console.WriteLine("\nInserire la quantità di denaro da depositare: ");
                        deposit = double.Parse(Console.ReadLine());
                        bool dp = BAccount.Deposit(deposit, found);
                        if (dp == true)
                            Console.WriteLine("Deposito riuscito!");
                        else
                            Console.WriteLine("Deposito non riuscito!");
                        break;

                    case 3:
                        Console.WriteLine("Nome correntista: " + BAccount.GetAccountHolder(found));
                        Console.WriteLine("Numero di conto corrente: " + BAccount.GetAccountNumber(found));
                        Console.WriteLine("Saldo disponibile: " + BAccount.GetBalance(found));                      
                        break;

                    default:
                        Console.WriteLine("Scelta sbagliata, riprova");
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}
