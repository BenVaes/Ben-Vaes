using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public partial class GameView : Form
    {
        public GameController controller;

        public GameView()
        {
            InitializeComponent();
            controller = new GameController();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            InputView input = controller.GetViewInput();

            Controls.Add(input);
        }
    }
}
