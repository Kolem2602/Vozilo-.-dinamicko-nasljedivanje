using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipitni_rok_26._04._2016
{
    class Autobus:Vozilo
    {
        private double brojPutnika;

        public Autobus (double brojPutnika, double masaVozila) : base(masaVozila)
        {
            this.brojPutnika = brojPutnika;
        }

        private double izracunajUkupnuMasu() 
        {
            return dohvatiMasu() + (brojPutnika + 3) * 95;
        }

        public override double UkupnaMasaVozila()
        {
            return izracunajUkupnuMasu();
        }

        public override string ToString()
        {
            return string.Format("Autobus - ukupna masa: {0} ", UkupnaMasaVozila());
        }

    }
}
