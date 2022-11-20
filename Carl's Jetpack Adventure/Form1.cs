using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Carl_s_Jetpack_Adventure
{
    public partial class Form1 : Form
    {



        int gameSpeed = 8; 
        int gravity = 7;
        int coins = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {

                gravity = -7;
                for (int i = 0; i <= 14; i++)
                {
                    carl.Image = Image.FromFile($"C:\\Users\\muril\\Desktop\\Assets jogo\\flying-frames\\tile0{i}.png");
                }
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;
                carl.Image = Image.FromFile("C:\\Users\\muril\\Desktop\\Assets jogo\\idle-frame.png");
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            coinText.Text += " Game over!!!"; 
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            carl.Top += gravity;
            carlCollider.Top += gravity;
            zapper1.Left -= gameSpeed;
            zapper2.Left -= gameSpeed; 
            coinText.Text = "Coins: " + coins;

            if (zapper1.Left < -150)
            {
                
                zapper1.Left = 800;
                coins++;
            }
            if (zapper2.Left < -180)
            {
                zapper2.Left = 950;
                coins++;
            }

            if (carlCollider.Bounds.IntersectsWith(zapper1.Bounds) ||
                carlCollider.Bounds.IntersectsWith(zapper2.Bounds) ||
                carlCollider.Bounds.IntersectsWith(ground.Bounds) || carlCollider.Top < -25
                )
            {
                endGame();
            }

            if (coins > 5)
            {
                gameSpeed = 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carl.BringToFront();
            zapper1.Image = Image.FromFile($"C:\\Users\\muril\\Desktop\\Assets jogo\\zapper-frames\\Zapper2.png");
            zapper2.Image = Image.FromFile($"C:\\Users\\muril\\Desktop\\Assets jogo\\zapper-frames\\Zapper2.png");
        }
    }
}
