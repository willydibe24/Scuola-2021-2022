using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Libro
{
    internal class Library
    {
        private string Name;
        private Book[] Books;
        private AncientBook[] AncientBooks;
        private int MaxBooks;
        private int NumberOfBooks;
        private int NumberOfAncient;
        public Library (string Name, int MaxBooks, int NumberOfBooks, int NumberOfAncient)
        {
            this.Name = Name;
            this.MaxBooks = MaxBooks;
            this.NumberOfBooks = NumberOfBooks;
            this.NumberOfAncient = NumberOfAncient;
            Books = new Book[MaxBooks];
            AncientBooks = new AncientBook[NumberOfAncient];
        }

        public void SetBooks(Book book, int i)
        {
            Books[i] = book;
        }

        public void SetAncient(AncientBook ancient, int i)
        {
            AncientBooks[i] = ancient;
        }

        public string ViewLibrary()
        {
            return "\nNome biblioteca: " + Name + "\nCapienza massima: " + MaxBooks + "\nNumero di libri: " + NumberOfBooks + "\nNumero di libri antichi: " + NumberOfAncient;
        }

        public string AddBook(Book book)
        {
            Books[NumberOfBooks] = book; // NumberOfBooks è la posizione nella quale dovrà essere aggiunto il libro            
            NumberOfBooks++;
            return "\nLibro aggiunto";
        }

        public bool FindBook(string title, int i)
        {
            if (Books[i].GetTitle() == title)
                return true;
            else
                return false;             
        }

        public string ViewAncientBooks(int i)
        {
            return "\nTitolo del " + (i + 1) + "° libro antico: " + AncientBooks[i].GetTitle();
        }
    }
}
