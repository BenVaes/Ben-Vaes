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
    public partial class TeerlingView : UserControl
    {
        // member die de controller onthoudt
        private TeerlingController controller;

        //Constructor
        public TeerlingView(TeerlingController teerlingController)
        {
            InitializeComponent();
            controller = teerlingController;
        }

        private void teerling_Click(object sender, EventArgs e)
        {
            // Waarde omdraaien
            controller.toggleVast();
        }

        private void werpButton_Click(object sender, EventArgs e)
        {
            // Controleer of de teerling niet vast staat
            if (!controller.Vast)
            {
                // Voer een worp uit
                controller.Werp();
            }
        }

        // Update view 
        public void updateUI()
        {
            lblTeerlingWaarde.BackColor = (controller.Vast) ? Color.Red : default(Color);
            lblTeerlingWaarde.Text = controller.AantalOgen.ToString();
        }

	        private void TeerlingView_Load(object sender, EventArgs e)
        {

        }
    }
}
