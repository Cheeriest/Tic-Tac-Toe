using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IXIGUL
{
    public partial class Form1 : Form
    {
        private char turn = 'X';
        private int turn_Num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender,EventArgs e)
        {
            if (sender is Button && ((Button)sender).Text == "")
            {
                ((Button)sender).Text = this.turn.ToString();
                if (this.turn == 'X')
                    this.turn = '0';
                else
                    this.turn = 'X';

            }

            string winner = this.CheckForWin();
            if (winner != "")
            {
                this.Text = winner;
                if (Text == "Draw")
                {
                    MessageBox.Show(Text);
                }
                else
                {
                    MessageBox.Show(Text + " Has Won!");
                }
                
            }
        }

        public string CheckForWin()
        {
            this.turn_Num++;
            
            for (int i = 0; i < 3; i++)
            {
                if (this.buttons[i, 0].Text == this.buttons[i, 1].Text && this.buttons[i, 1].Text == this.buttons[i, 2].Text)
                    return this.buttons[i, 0].Text;
            }

            for (int i = 0; i < 3; i++)
            {
                if (this.buttons[0, i].Text == this.buttons[1, i].Text && this.buttons[1, i].Text == this.buttons[2, i].Text)
                    return this.buttons[1, i].Text;
            }

            if (this.buttons[0, 0].Text == this.buttons[1, 1].Text && this.buttons[1, 1].Text == this.buttons[2, 2].Text)
            {
                return this.buttons[0, 0].Text;
            }

            if (this.buttons[0, 2].Text == this.buttons[1, 1].Text && this.buttons[1, 1].Text == this.buttons[2, 0].Text)
            {
                return this.buttons[0, 0].Text;
            }

            if (this.turn_Num == 9)
            {
                return "Draw";
            }
            return "";

        }
    }
}
