using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Tic_Tac_Toe_Project.frmTicTacToeGame;

namespace Tic_Tac_Toe_Project
{
    public partial class frmResults : Form
    {
        public static frmResults instance;
        public frmResults()
        {
            InitializeComponent();
            instance = this;
        }


        public void GetPlayersScore()
        {
            short Player1won = frmTicTacToeGame.GameStatus.Player1won;
            short Player2won = frmTicTacToeGame.GameStatus.Player2won;

            lblXtimeWon.Text = Player1won.ToString();
            lblOtimeWon.Text = Player2won.ToString();

            if(Player1won > Player2won)
            {
                lblWinnerUntilNow.Text = "X";
                lblWinnerUntilNow.Font = label2.Font;
            }

            else if(Player1won < Player2won)
            {
                lblWinnerUntilNow.Text = "O";
                lblWinnerUntilNow.Font = label2.Font;
            }

            else
            {
                lblWinnerUntilNow.Text = "No Winner";
                lblWinnerUntilNow.Font = label3.Font;
            }
        }

        public void AddNewAround(int RoundNumber, DateTime date, 
            frmTicTacToeGame.enWinner Winner)
        {

                date.ToLongTimeString();

                ListViewItem item = new ListViewItem("Round " + RoundNumber);

                if (Winner == enWinner.Player1)
                {
                    item.SubItems.Add("Player 1 (X)");
                    item.SubItems.Add("Player 2 (O)");
                }

                else if (Winner == enWinner.Player2)
                {
                    item.SubItems.Add("Player 2 (O)");
                    item.SubItems.Add("Player 1 (X)");
                }

                else
                {
                    item.SubItems.Add("No Winner");
                    item.SubItems.Add("No Winner");
                }

                item.SubItems.Add(date.ToString());

                ListView1.Items.Add(item);

        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTicTacToeGame.instance.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTicTacToeGame.instance.Visible = true;
        }

        private void delteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView1.Items.Remove(ListView1.SelectedItems[0]);
            
        }
    }
}
