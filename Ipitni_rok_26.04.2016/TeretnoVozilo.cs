using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipitni_rok_26._04._2016
{
    class TeretnoVozilo:Vozilo
    {
        private double masaTereta { get; set; }

        public TeretnoVozilo(double masaTereta, double masaVozila): base(masaVozila)
        {
            this.masaTereta = masaTereta;
        }

        private double izracunajUkupnuMasu()
        {
            return dohvatiMasu() + 95 + masaTereta;
        }

        public override double UkupnaMasaVozila()
        {
            return izracunajUkupnuMasu();
        }

        public override string ToString()
        {
            return string.Format("Kamion- ukupna masa:{0}",UkupnaMasaVozila());
        }
    }
}
