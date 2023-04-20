using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Libro
{
    internal class Book
    {
        protected string Title;
        protected string Author;
        protected string Editor;
        protected double Price;
        protected bool Lend; // prestito
        protected bool Avialable; // disponibile

        public Book (string Title, string Author, string Editor, double Price) // costruttore 
        {
            this.Title = Title;
            this.Author = Author;
            this.Editor = Editor;
            this.Price = Price;
            Lend = false;
            Avialable = true;
        }
        public string GetTitle() { return Title; }

        public virtual string ViewAll() // visualizza
        {
            return "\nTitolo: " + Title + "\nAutore: " + Author + "\nCasa editrice: " + Editor + "\nPrezzo: " + Price;
        }

        public string Lending() // prestito
        {
            if (Lend == false)
            {
                Lend = true;
                Avialable = false;
                return "\nLibro dato in prestito";
            }
            else
                return "\nLibro già dato in prestito";
        }
        public string GiveBack() // restituisci
        {
            if (Avialable == false)
            {
                Lend = false;
                Avialable = true;
                return "\nLibro restituito";
            }
            else
                return "\nLibro già restituito";
        }
    }
}
