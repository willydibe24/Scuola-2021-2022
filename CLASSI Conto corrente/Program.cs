using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Conto_corrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string num;
            bool r;
            
            Console.WriteLine("GESTIONE CONTO CORRENTE\n");
            Console.WriteLine("Inserire il nome del correntista: ");
            name = Console.ReadLine();
            Console.WriteLine("Inserire il numero di conto di" + name + ": ");
            num = Console.ReadLine();

            BankAccount BAccount = new BankAccount(name);

            r = BAccount.Authentication(name, num);
            if (r == true)
                Console.WriteLine("Autenticazione riuscita!");
            else
                Console.WriteLine("Autenticazione fallita! Il programma verrà chiuso");

            Console.ReadKey();
        }
    }
}
