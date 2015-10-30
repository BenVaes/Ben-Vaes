using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class YahtzeeController
    {
        private GameController container;

        private YahtzeeView view;
        private YahtzeeModel model;

        public YahtzeeController(GameController cont)
        {
            container = cont;
            view = new YahtzeeView(this);
            model = new YahtzeeModel();
        }

        public void initialize()
        {
            maakTeerlingen();
        }

        // Voeg aantal teerlingen toe aan het model
        private void maakTeerlingen()
        {
            // Loop over het aantal teerlingen dat er mogen zijn (gedefiniëerd in GameController)
            for (int teerlingNummer = 0; teerlingNummer < AantalTeerlingen; ++teerlingNummer)
            {
                // Maak een nieuwe teerling aan
                TeerlingController teerling = new TeerlingController();

                // Voeg de teerling toe aan het model
                model.addTeerling(teerling);
            }
        }

        public List<TeerlingView> getTeerlingenView()
        {
            // Maak een lijst die de views zal opvangen
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            // Loop over het huidig aantal teerlingen uit het model
            foreach (TeerlingController teerling in model.Teerlingen)
            {
                // Haal de view op voor iedere teerling
                TeerlingView teerlingView = teerling.getView();

                // Voeg de teerling toe aan de lijst die de views opvangt
                teerlingenView.Add(teerlingView);
            }

            // Return de lijst met teerlingViews
            return teerlingenView;
        }

        public YahtzeeView getView()
        {
            return view;
        }

        public void werpAlleTeerlingen()
        {
            // Controleer of het maximum aantal worpen niet is bereikt
            if (model.aantalWorpen < MaximumAantalWorpen)
            {
                // Haal de teerlingen op uit het model
                List<TeerlingController> teerlingen = model.Teerlingen;

                // Loop over de teerlingen
                foreach (TeerlingController teerling in teerlingen)
                {
                    // Voer de werp methode uit op elke teerling
                    teerling.Werp();
                }

                // Tel eentje bij het huidig aantal worpen
                model.voegWorpToe();
            }

            // Breng de container op de hoogte dat er veranderingen hebben plaatsgevonden
            container.modelHasChanged();
        }

        public int MaximumAantalWorpen
        {   
            get
            {
                return model.MaximumAantalWorpen;
            }
            set
            {
                model.MaximumAantalWorpen = value;
            }
            
        }

        public int HuidigAantalWorpen
        {
            get
            {
                return model.aantalWorpen;
            }
        }

        public int AantalTeerlingen
        {
            get
            {
                return model.AantalTeerlingen;
            }
            set
            {
                model.AantalTeerlingen = value;
            }
        }
    }
}
