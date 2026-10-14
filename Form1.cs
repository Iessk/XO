using System;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;
using XO1.Properties;

namespace XO1
{
    public partial class Form1 : Form
    {
        StGameStatus GameStatus;

        EnPlayer PlayerTurn = EnPlayer.Player1;

        enum EnPlayer
        {
            Player1,
            Player2
        }

        enum EnWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct StGameStatus
        {
            public EnWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        PictureBox[,] cells = new PictureBox[3, 3];


        public Form1()
        {
            InitializeComponent();

            cells[0, 0] = PB00;
            cells[0, 1] = PB01;
            cells[0, 2] = PB02;

            cells[1, 0] = PB10;
            cells[1, 1] = PB11;
            cells[1, 2] = PB12;

            cells[2, 0] = PB20;
            cells[2, 1] = PB21;
            cells[2, 2] = PB22;
        }


        public bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag != null &&
                pb1.Tag.ToString() != "?" &&
                pb1.Tag.ToString() == pb2.Tag?.ToString() &&
                pb1.Tag.ToString() == pb3.Tag?.ToString())
            {
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;

                if (pb1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = EnWinner.Player1;
                }
                else
                {
                    GameStatus.Winner = EnWinner.Player2;
                }

                GameStatus.GameOver = true;

                EndGame();

                return true;
            }

            return false;
        }


        public void CheckWinner()
        {
            // Rows

            if (CheckValues(cells[0, 0], cells[0, 1], cells[0, 2]))
                return;

            if (CheckValues(cells[1, 0], cells[1, 1], cells[1, 2]))
                return;

            if (CheckValues(cells[2, 0], cells[2, 1], cells[2, 2]))
                return;


            // Columns

            if (CheckValues(cells[0, 0], cells[1, 0], cells[2, 0]))
                return;

            if (CheckValues(cells[0, 1], cells[1, 1], cells[2, 1]))
                return;

            if (CheckValues(cells[0, 2], cells[1, 2], cells[2, 2]))
                return;


            // Diagonals

            if (CheckValues(cells[0, 0], cells[1, 1], cells[2, 2]))
                return;

            if (CheckValues(cells[0, 2], cells[1, 1], cells[2, 0]))
                return;


            // Draw

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = EnWinner.Draw;

                EndGame();
            }
        }


        void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case EnWinner.Player1:
                    lblWinner.Text = "Player1";
                    break;

                case EnWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;

                case EnWinner.Draw:
                    lblWinner.Text = "Draw";
                    break;

                default:
                    lblWinner.Text = "In Progress";
                    break;
            }

            foreach (PictureBox pb in cells)
            {
                pb.Enabled = false;
            }

            MessageBox.Show(
                "Game Over",
                "Game Over",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        public void ChangeImage(PictureBox pb)
        {
            if (GameStatus.GameOver)
                return;


            if (pb.Tag != null && pb.Tag.ToString() != "?")
            {
                MessageBox.Show(
                    "Wrong Choice",
                    "Already Chosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            switch (PlayerTurn)
            {
                case EnPlayer.Player1:

                    pb.BackgroundImage = Resources.X;
                    pb.Tag = "X";

                    PlayerTurn = EnPlayer.Player2;
                    lblTurn.Text = "Player 2";

                    GameStatus.PlayCount++;

                    break;


                case EnPlayer.Player2:

                    pb.BackgroundImage = Resources.O;
                    pb.Tag = "O";

                    PlayerTurn = EnPlayer.Player1;
                    lblTurn.Text = "Player 1";

                    GameStatus.PlayCount++;

                    break;
            }


            CheckWinner();
        }


        private void PB_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }


        private void ResetPictureBox(PictureBox pb)
        {
            pb.BackgroundImage = Resources.QMark;
            pb.Tag = "?";
            pb.BackColor = Color.Transparent;
            pb.Enabled = true;
        }


        private void RestartGame()
        {
            foreach (PictureBox pb in cells)
            {
                ResetPictureBox(pb);
            }

            PlayerTurn = EnPlayer.Player1;

            lblTurn.Text = "Player 1";

            GameStatus.PlayCount = 0;

            GameStatus.GameOver = false;

            GameStatus.Winner = EnWinner.GameInProgress;

            lblWinner.Text = "In Progress";
        }


        private void BtnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}