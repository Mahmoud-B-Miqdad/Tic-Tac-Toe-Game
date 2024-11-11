using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Project.Properties;

namespace Tic_Tac_Toe_Project
{
    public partial class frmTicTacToeGame : Form
    {

        public static frmTicTacToeGame instance;
        public static stGameStatus GameStatus;
        private frmResults frmResult = new frmResults() ;
        public static int RoundNumber = 1;
        enPlayer PlayerTurn = enPlayer.Player1;

        public frmTicTacToeGame()
        {
            InitializeComponent();
            instance = this;
            //frmResult = new frmResults();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 8;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 310, 60, 310, 360);
            e.Graphics.DrawLine(pen, 460, 60, 460, 360);
            e.Graphics.DrawLine(pen, 160, 160, 610, 160);
            e.Graphics.DrawLine(pen, 160, 270, 610, 270);

            Pen pen2 = new Pen(Color.Gray);
            pen2.Width = 5;

            pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen2.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen2.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen2, 13, 97,123 , 97);
            e.Graphics.DrawLine(pen2, 13, 175, 122, 175);
            e.Graphics.DrawLine(pen2, 13, 271, 123, 270);

            
        }

        public struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
            public short Player1won;
            public short Player2won;
            public short DrawTime;
        }

        enum enPlayer
        {
            Player1,
            Player2,
            GameOver
        };
        public enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        };


        void MakeGameOver(string Message, string title)
        {
            MessageBox.Show(Message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void EndGame()
        {

            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    //lblWinner.ForeColor = Color.YellowGreen;
                    break;
                    
            }

            lblPlayer1won.Text = GameStatus.Player1won.ToString();
            lblPlayer2won.Text = GameStatus.Player2won.ToString();
            lblDrowTime.Text = GameStatus.DrawTime.ToString();

            MakeGameOver("Game Over (^_^)", "Game Over");
        }

        void WhosWinner(Button btn)
        {
            if (btn.Tag.ToString() == "X")
            {
                GameStatus.Winner = enWinner.Player1;
                GameStatus.Player1won++;
                EndGame();

            }

            else if (btn.Tag.ToString() == "O")
            {
                GameStatus.Winner = enWinner.Player2;
                GameStatus.Player2won++;
                EndGame();
            }

            else
            {
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        bool CheckValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag 
                && btn1.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.Yellow;
                btn2.BackColor = Color.Yellow;
                btn3.BackColor = Color.Yellow;

                GameStatus.GameOver = true;
                PlayerTurn = enPlayer.GameOver;

                WhosWinner(btn1);
                return true;
            }
            GameStatus.GameOver = false;
            return false;
        }
            
        void CheckIFWinner()
        {
            if (CheckValue(btn1, btn2, btn3))
                return;

            if (CheckValue(btn4, btn5, btn6))
                return;

            if (CheckValue(btn7, btn8, btn9))
                return;

            if (CheckValue(btn1, btn4, btn7))
                return;

            if (CheckValue(btn2, btn5, btn8))
                return;

            if (CheckValue(btn3, btn6, btn9))
                return;

            if (CheckValue(btn1, btn5, btn9))
                return;

            if (CheckValue(btn3, btn5, btn7))
                return;
        }
        void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        btn.Tag = "X";
                        lblTurn.Text = "Player 2";
                        PlayerTurn = enPlayer.Player2;
                        GameStatus.PlayCount++;
                        CheckIFWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        btn.Tag = "O";
                        lblTurn.Text = "Player 1";
                        PlayerTurn = enPlayer.Player1;
                        GameStatus.PlayCount++;
                        CheckIFWinner();
                        break;

                    case enPlayer.GameOver:
                        MessageBox.Show("Game Over, Please Rstart The Game",
                            "Erorr",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }


                else
                {
                    MessageBox.Show("Wrong Choise!!","Erorr",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            if(GameStatus.PlayCount == 9 && GameStatus.GameOver == false)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                GameStatus.DrawTime++;
                EndGame();
                
            }

        }

        void ResetButtons(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor= Color.Black;
        }

        void RstartGame()
        {
            ResetButtons(btn1);
            ResetButtons(btn2);
            ResetButtons(btn3);
            ResetButtons(btn4);
            ResetButtons(btn5);
            ResetButtons(btn6);
            ResetButtons(btn7);
            ResetButtons(btn8);
            ResetButtons(btn9);

            DateTime Date = DateTime.Now;

            frmResult.AddNewAround(RoundNumber, Date, GameStatus.Winner);
            frmResult.GetPlayersScore();
            RoundNumber++;


            PlayerTurn = enPlayer.Player1;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.PlayCount = 0;
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";

           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RstartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmResult.Visible = true;
            this.Visible = false;
        }


    }
}
