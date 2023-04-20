using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Libro
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // Variabili biblioteca
            string libraryname;  
            int maxbooks;
            int numberofbooks;
            // Variabili libro
            string title;
            string author;
            string editor;
            double price;
            // Variabili libro antico
            int numberofancient;
            int year;
            int conservation;
            // Altre variabili 
            bool o; // variabile booleana relativa a option, utilizzata nel tryparse
            int option;
            bool found = false;
            string find;

            Console.WriteLine("GESTIONE LIBRI BIBLIOTECA\n--------------------------------");
            Console.WriteLine("\nInserire il nome della biblioteca: ");
            libraryname = Console.ReadLine();
            Console.WriteLine("\nInserire la capienza massima della biblioteca: ");
            maxbooks = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("\nInserire il numero di libri presenti nella biblioteca (esclusi i libri antichi): ");
                numberofbooks = int.Parse(Console.ReadLine());
                if (numberofbooks > maxbooks)
                    Console.WriteLine("\nSi sta cercando di aggiungere un numero di libri oltre la capienza massima, riprovare");
            } while (numberofbooks > maxbooks);

            do
            {
                Console.WriteLine("\nInserire il numero di libri antichi presenti (si sommano ai libri già presenti): ");
                numberofancient = int.Parse(Console.ReadLine());
                if (numberofbooks + numberofancient > maxbooks)
                    Console.WriteLine("\nSi sta cercando di aggiungere un numero di libri oltre la capienza massima, riprovare");
            } while (numberofbooks + numberofancient > maxbooks);

            Library library = new Library(libraryname, maxbooks, numberofbooks, numberofancient);
            Book[] book = new Book[maxbooks];
            AncientBook[] ancientbook = new AncientBook[maxbooks];

            for (int i = 0; i < numberofbooks; i++)
            {
                Console.WriteLine("\nInserire il titolo del " + (i + 1) + "° libro: ");
                title = Console.ReadLine();
                Console.WriteLine("\nInserire l'autore del libro ''" + title + "'': ");
                author = Console.ReadLine();
                Console.WriteLine("\nInserire la casa editrice del libro ''" + title + "'': ");
                editor = Console.ReadLine();
                Console.WriteLine("\nInserire il prezzo del libro ''" + title + "'': ");
                price = double.Parse(Console.ReadLine());

                book[i] = new Book(title, author, editor, price); // viene istanziato l'oggetto libro              
                library.SetBooks(book[i], i); // viene aggiunto il libro nel vettore di libri della biblioteca
            }

            for (int i = 0; i < numberofancient; i++)
            {
                Console.WriteLine("\nInserire il titolo del " + (i + 1) + "° libro antico: ");
                title = Console.ReadLine();
                Console.WriteLine("\nInserire l'autore del libro ''" + title + "'': ");
                author = Console.ReadLine();
                Console.WriteLine("\nInserire la casa editrice del libro ''" + title + "'': ");
                editor = Console.ReadLine();
                Console.WriteLine("\nInserire il prezzo del libro ''" + title + "'': ");
                price = double.Parse(Console.ReadLine());
                Console.WriteLine("\nInserire l'anno di produzione del libro ''" + title + "'': ");
                year = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("\nInserire lo stato di conservazione del libro ''" + title + "'' (da 1 se è conservato male a 5 se è conservato bene): ");
                    conservation = int.Parse(Console.ReadLine());
                } while (conservation <= 0 || conservation > 5);

                ancientbook[i] = new AncientBook(title, author, editor, price, year, conservation);
                library.SetAncient(ancientbook[i], i);
            }

            do
            {
                do 
                { 
                    Console.WriteLine("\nMENU"+
                    "\n1)Visualizza le caratteristiche di un libro" +
                    "\n2)Imposta lo stato di un libro su IN PRESTITO" +
                    "\n3)Imposta lo stato di un libro su RESTITUITO" +
                    "\n4)Visualizza le caratteristiche di un libro antico" +
                    "\n5)Aggiorna lo stato di conservazione di un libro antico" +
                    "\n6)Visualizza tutte le caratteristiche della biblioteca" +
                    "\n7)Aggiungi un libro" +
                    "\n8)Ricerca un libro" +
                    "\n9)Visualizza l'elenco dei libri antichi" +
                    "\n0)Esci");

                    o = int.TryParse(Console.ReadLine(), out option);
                    if (o == false)
                        Console.WriteLine("\nScelta errata, riprova");

                } while (o == false);
               
                switch (option)
                {
                    default:
                        Console.WriteLine("\nScelta errata, riprova");
                        break;

                    case 0:
                        Console.WriteLine("\nIl programma verrà chiuso");
                        break;

                    case 1:
                        Console.WriteLine("\nInserire il titolo del libro: ");
                        find = Console.ReadLine();
                        for (int i = 0; i < numberofbooks; i++)
                        {
                            if (find == book[i].GetTitle())
                            {
                                Console.WriteLine(book[i].ViewAll());
                                found = true;
                            }
                        }
                        if (found == false)
                            Console.WriteLine("\nLibro non trovato, riprova");
                        found = false;
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("\nInserire il titolo del libro: ");
                            find = Console.ReadLine();
                            for (int i = 0; i < numberofbooks; i++)
                            {
                                if (find == book[i].GetTitle())
                                {
                                    found = true;
                                    Console.WriteLine(book[i].Lending());
                                }
                            }
                        } while (found == false);
                        found = false;
                        break;

                    case 3:
                        Console.WriteLine("\nInserire il titolo del libro: ");
                        find = Console.ReadLine();
                        for (int i = 0; i < numberofbooks; i++)
                        {
                            if (find == book[i].GetTitle())
                            {
                                found = true;
                                Console.WriteLine(book[i].GiveBack());                         
                            }
                        }
                        found = false;
                        break;

                    case 4:
                        Console.WriteLine("\nInserire il titolo del libro antico: ");
                        find = Console.ReadLine();
                        for (int i = 0; i < numberofancient; i++)
                        {
                            if (find == ancientbook[i].GetTitle())
                            {
                                found = true;
                                Console.WriteLine(ancientbook[i].ViewAll());
                            }
                        }
                        found = false;
                        break;

                    case 5:
                        Console.WriteLine("\nInserire il titolo del libro antico: ");
                        find = Console.ReadLine();
                            
                        for (int i = 0; i < numberofancient; i++)
                        {
                            if (find == ancientbook[i].GetTitle())
                            {
                                found = true;
                                do
                                {
                                    Console.WriteLine("\nInserire il nuovo stato di conservazione: ");
                                    conservation = int.Parse(Console.ReadLine());
                                } while (conservation <= 0 || conservation > 5);
                                Console.WriteLine(ancientbook[i].UpdateConservation(conservation));
                            }
                        }
                        found = false;
                        break;

                    case 6:
                        Console.WriteLine(library.ViewLibrary());
                        break;

                    case 7:
                        if ((numberofbooks + numberofancient) < maxbooks)
                        {
                            Console.WriteLine("\nInserire il titolo del libro: ");
                            title = Console.ReadLine();
                            Console.WriteLine("\nInserire l'autore del libro ''" + title + "'': ");
                            author = Console.ReadLine();
                            Console.WriteLine("\nInserire la casa editrice del libro ''" + title + "'': ");
                            editor = Console.ReadLine();
                            Console.WriteLine("\nInserire il prezzo del libro ''" + title + "'': ");
                            price = double.Parse(Console.ReadLine());

                            Book addbook = new Book(title, author, editor, price);
                            Console.WriteLine(library.AddBook(addbook));
                            numberofbooks++;
                        }
                        else
                            Console.WriteLine("\nLibro non aggiunto. Capienza biblioteca al massimo.");
                        break;

                    case 8:
                        Console.WriteLine("\nInserire il titolo del libro da ricercare: ");
                        find = Console.ReadLine();

                        for (int i = 0; i < numberofbooks; i++)
                        {
                            found = library.FindBook(find, i);
                            if (found == true)
                            {

                                Console.WriteLine("\nLibro trovato");
                                break;
                            }
                        }               
                        if (found == false)
                            Console.WriteLine("\nLibro non trovato");
                        break;

                    case 9:
                        for (int i = 0; i < numberofancient; i++)
                        {
                            Console.WriteLine(library.ViewAncientBooks(i)); 
                        }
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}
