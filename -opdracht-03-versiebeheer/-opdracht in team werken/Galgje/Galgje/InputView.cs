using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Galgje
{
    public partial class InputView : UserControl
    {
        private LetterModel model;
        private InputController controller;
        private string hiddenWord = "";
        public InputView(InputController i, LetterModel m)
        {
            InitializeComponent();
            this.model = m;
            this.controller = i;
            foreach (char item in model.Woord.ToCharArray())
            {
                hiddenWord += "_ ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Char.IsDigit(Convert.ToChar(textBox1.Text)))
                {
                    listBox1.Items.Add(textBox1.Text);
                }
                else { label1.Text = "Invalid entry"; }

                if (controller.compareToWord(Convert.ToChar(textBox1.Text)))
                {
                    hiddenWord = "";
                    foreach (char item in model.Woord.ToCharArray())
                    {
                        if (listBox1.Items.Contains(item.ToString()))
                        {
                            hiddenWord += item;
                        }
                        else
                        {
                            hiddenWord += " _ ";
                        }
                    }
                    Woord.Text = "Woord: " + hiddenWord;
                }
                else
                {
                    model.Levens--;
                    Levens.Text = "Levens: " + model.Levens;
                    if (model.Levens <= 0)
                    {
                        Infolabel.Text = "GAME OVER";
                        controller.disableControls(button1, listBox1, textBox1, raadwoord, textBox2);
                    }
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void InputView_Load(object sender, EventArgs e)
        {
            Woord.Text = "Woord: " + hiddenWord;
            Levens.Text = "Levens: " + model.Levens;
        }

        private void raadwoord_Click(object sender, EventArgs e)
        {
            if (model.Woord == textBox2.Text)
            {
                Infolabel.Text = "YOU WIN";
                Infolabel.ForeColor = Color.Green;
                controller.disableControls(button1, listBox1, textBox1,raadwoord,textBox2);
            }
            else
            {
                model.Levens += -3;
                Levens.Text = "Levens: " + model.Levens;
                if (model.Levens <= 0)
                {
                    Infolabel.Text = "GAME OVER";
                    controller.disableControls(button1, listBox1, textBox1, raadwoord, textBox2);
                }
            }
        }
    }
}
