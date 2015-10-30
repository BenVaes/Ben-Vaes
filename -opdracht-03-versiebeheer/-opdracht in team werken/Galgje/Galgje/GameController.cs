using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    public class GameController
    {
        private LetterModel _letter;
        private GameView _view;
        private LetterModel _model;

        private InputController _input;

        public List<string> woorden = new List<string>() {"appel","banaan","kalender","computerscherm"};

        public int aantalKansen = 10;

        
        public GameController()
        {
            Random temp = new Random();
            _model = new LetterModel(woorden[temp.Next(0,woorden.Count-1)]);

            this._view = new GameView(this);

            this._input = new InputController(this._model);
        }

        public InputView GetViewInput()
        {
            return _input.getView();
        }
    }
}
