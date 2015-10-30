using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    public class LetterModel
    {
        private string woord;
        private int levens = 10;

        public string Woord
        {
            get { return woord; }
            set { woord = value; }
        }

        public int Levens
        {
            get { return levens; }
            set { levens = value; }
        }

        public LetterModel(string woord)
        {
            this.Woord = woord;
        }
    }
}
