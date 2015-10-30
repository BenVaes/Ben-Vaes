using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeBenVaes
{
    class TeerlingModel
    {
        private bool isVast;
        private int aantalOgen;
        private static Random randomNummer;

        public TeerlingModel()
        {
            // Zet elke teerling standaard los
            isVast = false;

            // Standaard waarde is 1
            aantalOgen = 1;

            // Maak een instantie van de random generator
            if (randomNummer == null)
            {
                randomNummer = new Random();
            }
        }

        // Bereken willekeurig getal
        public void Werp()
        {
            aantalOgen = randomNummer.Next(1, 7);
        }

        public int AantalOgen
        {
            get
            {
                return aantalOgen;
            }
        }

        public void toggleVast()
        {
            isVast = !isVast;
        }

        public bool Vast
        {
            get
            {
                return isVast;
            }
        }
    }
}
