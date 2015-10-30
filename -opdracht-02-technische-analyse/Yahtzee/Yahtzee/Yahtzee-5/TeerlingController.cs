using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class TeerlingController
    {
        private TeerlingModel model;
        private TeerlingView view;

        // Constructor
        public TeerlingController()
        {
            model = new TeerlingModel();
            view = new TeerlingView(this);
        }

        public TeerlingView getView()
        {
            return view;
        }

        public void Werp()
        {
            // Controleer of de teerling niet is vastgezet
            if (!model.Vast)
            {
                // Voer de random generator in het model uit
                model.Werp();

                // Update de view
                view.updateUI();
            }
        }

        // Draai de 'isVast' waarde om wanneer er op de teerling wordt geklikt
        public void toggleVast()
        {
            // Zeg tegen het model dat de teerling isVast waarde moet omgedraaid worden
            model.toggleVast();

            // Update de view met de nieuwe waarde die de teerling heeft gekregen
            view.updateUI();
        }

        public bool Vast
        {
            get
            {
                return model.Vast;
            }
        }

        public int AantalOgen
        {
            get
            {
                return model.AantalOgen;
            }
        }
    }
}
