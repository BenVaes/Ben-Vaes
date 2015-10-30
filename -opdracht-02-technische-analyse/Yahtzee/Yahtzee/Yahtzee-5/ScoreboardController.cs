using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class ScoreboardController
    {
        private GameController container;

        private ScoreboardView view;
        private ScoreboardModel model;

        //Constructor
        public ScoreboardController( GameController cont )
        {
            container = cont;

            view = new ScoreboardView(this);
            model = new ScoreboardModel();
        }

        public ScoreboardView getView()
        {
            return view;
        }

        public int MaximumAantalWorpen
        {
            get
            {
                // Return de waarde van maximumaantalworpen uit de bovenliggende klasse
                return container.MaximumAantalWorpen;
            }
        }

        public int HuidigAantalWorpen
        {
            get
            {
                // Return de waarde van huidig aantal worpen uit bovenliggende klasse
                return container.HuidigAantalWorpen;
            }
        }

        public void updateView()
        {
            view.updateView();
        }

    }
}
