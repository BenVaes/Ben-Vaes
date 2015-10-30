using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    public partial class YahtzeeView : UserControl
    {
        private YahtzeeController controller;

        public YahtzeeView(YahtzeeController yahtzeeController)
        { 
            controller = yahtzeeController;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
            List<TeerlingView> teerlingen = controller.getTeerlingenView();

            int teerlingWidth = teerlingen.First().Width;
            int teerlingHeight = teerlingen.First().Height;

            // Teerlingen overlopen om zo de horizontale positie van elke teerling te kunnen bepalen
            foreach (TeerlingView teerling in teerlingen)
            {
                // View van één teerling ophalen
                TeerlingView huidigeTeerling = teerling;

                int xPos = teerlingen.IndexOf(teerling) * teerlingWidth;

                // De positie van de huidige teerling setten
                huidigeTeerling.Location = new Point(xPos, 0);

                // De view van de huidige teerling toevoegen
                Controls.Add(huidigeTeerling);
            }

            btnWerpAllemaal.Location = new Point(10, teerlingHeight );
        }

        private void smijtAlleTeerlingenButton_click(object sender, EventArgs e)
        {
            // Roep de werpAlleTeerlingen methode aan die in de controller gedefinieerd is
            controller.werpAlleTeerlingen();
        }
    }
}
