using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pacman_game
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=DESKTOP-P50RCLO;Initial Catalog=PACMAN;Integrated Security=True";
        bool goup, godown, goleft, goright, isGameOver;
        int score, playerspeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;
        string res;
        int timesPlayed=0;
        public MainForm()
        {
            InitializeComponent();
            resetGame();
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (isGameOver == true)
            {
                resetGame();
            }
        }
        private void gametimer_Tick(object sender, EventArgs e)
        {
            txtscore.Text = "Score: " + score;
            if (goleft == true)
            {
                pacman.Left -= playerspeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goright == true)
            {
                pacman.Left += playerspeed;
                pacman.Image = Properties.Resources.right;
            }
            if (godown == true)
            {
                pacman.Top += playerspeed;
                pacman.Image = Properties.Resources.down;
            }
            if (goup == true)
            {
                pacman.Top -= playerspeed;
                pacman.Image = Properties.Resources.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 700;
            }
            if (pacman.Left > 700)
            {
                pacman.Left = -10;
            }

            if (pacman.Top < -10)
            {
                pacman.Top = 550;
            }
            if (pacman.Top > 550)
            {
                pacman.Top = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                            res = "You Lose!";
                        }

                        if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                    }

                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                            res = "You Lose!";
                        }
                    }
                }
            }
            // moving ghosts
            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(wall2.Bounds) || redGhost.Bounds.IntersectsWith(wall3.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }
            yellowGhost.Left -= yellowGhostSpeed;

            if (yellowGhost.Bounds.IntersectsWith(wall4.Bounds) || yellowGhost.Bounds.IntersectsWith(wall1.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }
            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;
            if (pinkGhost.Top < 0 || pinkGhost.Top > 520)
            {
                pinkGhostY = -pinkGhostY;
            }
            if (pinkGhost.Left < 0 || pinkGhost.Left > 680)
            {
                pinkGhostX = -pinkGhostX;
            }
            if (score == 95)
            {
                gameOver("You Win!");
                res = "You Win!";
            }
        }

        private void resetGame()
        {
            txtscore.Text = "Score: 0";
            score = 0;
            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerspeed = 8;
            //false condition
            goup = false; 
            godown = false;
            goleft = false;
            goright = false;

            isGameOver = false;

            pacman.Left = 12;
            pacman.Top = 75;

            redGhost.Left = 376;
            redGhost.Top = 106;

            yellowGhost.Left = 220;
            yellowGhost.Top = 408;

            pinkGhost.Left = 393;
            pinkGhost.Top = 247;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }
            gametimer.Start();

        }
        private void gameOver(string message)
        {
            isGameOver = true;
            gametimer.Stop();
            txtscore.Text = "Score: " + score + Environment.NewLine + message;
            MessageBoxButtons boxButtons = MessageBoxButtons.RetryCancel;
            DialogResult result = MessageBox.Show(txtscore.Text, "Game Over", boxButtons, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Retry)
            {
                resetGame();
            }
            if (result == DialogResult.Cancel)
            {
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.Show();
                this.Hide();
            }
            timesPlayed++;
            

            SqlConnection con = new SqlConnection(connectionString);
            
                con.Open();

            string query = "INSERT INTO hadinaeem(TIMESPLAYED, SCORE, RESULT) VALUES('"+timesPlayed+ "', '"+score+"', '"+res+"')";
            SqlCommand cmd = new SqlCommand(query, con);
                
                cmd.ExecuteNonQuery();  // Execute the query once
        }
    }
}