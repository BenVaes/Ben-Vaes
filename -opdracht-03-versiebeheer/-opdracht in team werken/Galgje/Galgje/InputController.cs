using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public class InputController
    {
        InputView _view;
        LetterModel _model;

        public InputController(LetterModel m)
        {
            this._view = new InputView(this,m);
            this._model = m;
        }
        public InputView getView()
        {
            return _view;
        }

        public bool compareToWord(char m)
        {
            char[] tempArray = _model.Woord.ToCharArray();
            if (tempArray.Contains(m))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void disableControls(Button button, ListBox listbox, TextBox textbox, Button button2, TextBox textbox2)
        {
            listbox.Enabled = false;
            button.Enabled = false;
            textbox.Enabled = false;
            button2.Enabled = false;
            textbox2.Enabled = false;
        }
    }
}
