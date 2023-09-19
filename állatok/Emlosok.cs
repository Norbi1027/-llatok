using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace állatok
{
    internal class Emlosok
    {
        public string Nev;
        public string faj;
        public int labszam;
        public double suly;
        public string nem;
        string hang;
        public string getHangotAd()
        {
            return hang;
        }

        public void setHangotAd(string hang)
        {
            this.hang = hang;
        }

        public string halad()
        {
            return "előre";
        }

        public override string ToString()
        {
            return this.Nev;
        }

        public Emlosok(string Nev,string faj, int labszam, double suly, string nem, string hang)
        {
            this.Nev = Nev;
            this.faj = faj;
            this.labszam = labszam;
            this.suly = suly;
            this.nem = nem;
            this.hang = hang;
        }
    }
}
