using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTTOCLASSI_Libro
{
    internal class AncientBook : Book
    {
        private int Year;
        private int Conservation; // ritorna 1 se è conservato bene, 2 se è conservato discretamente, 3 se è conservato male

        public AncientBook(string Title, string Author, string Editor, double Price, int Year, int Conservation) : base(Title, Author, Editor, Price)
        {
            this.Year = Year;
            this.Conservation = Conservation;
            Lend = false;
        }
        public new string GetTitle() { return Title; }
        public override string ViewAll()
        {
            return base.ViewAll() + "\nAnno: " + Year + "\nStato di conservazione: " + Conservation;
        }

        public string UpdateConservation (int c)
        {
            Conservation = c;
            return "\nStato di conservazione: " + Conservation;
        }
    }
}
