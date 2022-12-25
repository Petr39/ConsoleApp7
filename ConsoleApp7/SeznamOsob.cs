using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class SeznamOsob
    {
        private string Jmeno { get; set; }
        private string Pozice { get; set; }
        private int Vek { get; set; }


        public SeznamOsob(string jmeno, string pozice, int vek)
        {
            Jmeno = jmeno;
            Pozice = pozice;
            Vek = vek;
        }

        public override string ToString()
        {
            return String.Format("{0}     {1}     {2}", Jmeno,Vek,Pozice);
        }
    }
}
