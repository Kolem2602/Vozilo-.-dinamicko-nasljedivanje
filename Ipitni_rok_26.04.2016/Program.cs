using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipitni_rok_26._04._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            Autobus a1 = new Autobus(32, 3200);
            Autobus a2 = new Autobus(7, 1500);
            Autobus a3 = new Autobus(62, 900);

            TeretnoVozilo k1 = new TeretnoVozilo(1500, 2000);
            TeretnoVozilo k2 = new TeretnoVozilo(2500, 1000);
            TeretnoVozilo k3 = new TeretnoVozilo(300, 500);

            vozila.Add(a1);
            vozila.Add(a2);
            vozila.Add(a3);
            vozila.Add(k1);
            vozila.Add(k2);
            vozila.Add(k3);

            foreach (Vozilo v in vozila)
            {
                if (v.UkupnaMasaVozila()>4500)
                {
                    Console.WriteLine("Nije dozvoljen prelazak mosta za vozilo: {0}", v.ToString());
                }
                else
                {
                    Console.WriteLine("Dozvoljen je prelazak mosta za vozilo: {0}", v.ToString());
                } 

            }
        }
    }
}
