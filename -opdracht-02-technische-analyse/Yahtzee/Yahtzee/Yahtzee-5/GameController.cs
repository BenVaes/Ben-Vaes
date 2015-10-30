using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class GameController
    {
        private GameView view;

        private YahtzeeController yahtzee;
        private ScoreboardController scoreboard;

        public GameController()
        {
            view = new GameView( this );
            yahtzee = new YahtzeeController( this );

            // Max aantal worpen en aantal teerlingen invullen
            yahtzee.MaximumAantalWorpen = 5;
            yahtzee.AantalTeerlingen = 3;

            // yahtzee uitvoeren met variabelen
            yahtzee.initialize();

            scoreboard = new ScoreboardController( this );
        }

        public void modelHasChanged()
        {
            scoreboard.updateView();
        }

        public GameView getView()
        {
            return view;
        }
        
        public YahtzeeView getViewYahtzee()
        {
            return yahtzee.getView();
        }

        public ScoreboardView getViewScoreboard()
        {
            return scoreboard.getView();
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return yahtzee.MaximumAantalWorpen;
            }
        }

        public int HuidigAantalWorpen
        {
            get
            {
                return yahtzee.HuidigAantalWorpen;
            }
        }
    }
}
