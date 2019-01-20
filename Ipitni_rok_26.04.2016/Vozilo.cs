using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipitni_rok_26._04._2016
{
    class Vozilo
    {
        private double MasaVozila;
        

        public double dohvatiMasu()
        {
            return MasaVozila;
        }

        public Vozilo(double masaVozila)
        {
            this.MasaVozila = masaVozila;
        }
        public virtual double UkupnaMasaVozila ()
        {
            return MasaVozila;
        }
    }
}
