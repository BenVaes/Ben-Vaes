using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    public partial class GameView : Form
    {
        private GameController controller;

        //Constructor
        public GameView( GameController Controller )
        {
            controller = Controller;

            InitializeComponent();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            ScoreboardView scoreboard = controller.getViewScoreboard();
            YahtzeeView yahtzee = controller.getViewYahtzee();

            yahtzee.Location = new Point(0, scoreboard.Height);


            Controls.Add( scoreboard );
            Controls.Add( yahtzee );
        }
    }
}
