using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Studente
{
    internal class Studente
    {
        private string sName;
        private int vote;
        private int sum;

        public string name
        {
            get { return sName; }
            set { sName = value; }
        }
        public int Vote
        {
            get { return vote; }
            set 
            { 
                vote = value;
                sum = sum + vote;
            }
        }

        public double Media (int nVotes)
        {
            return Math.Round((double)(sum) / nVotes , 2); 
        }
        public int GetLast
        {
            get { return vote; }
        }
    }
}