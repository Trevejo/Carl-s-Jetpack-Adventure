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
    public partial class Game : Form
    {
        int gameSpeed = 8; 
        int gravity = 7;
        int coins = 0;
        int distance = 0;
        int dist = 250;
        bool death = false;
        public static int totalCoins;

        Random rnd = new Random();
        List<PictureBox> coin = new List<PictureBox>();
        List<PictureBox> zapper = new List<PictureBox>();

        private List<string> runFrames = new List<string>(new String[] {"run1","run2", "run3", "run4", "run5", "run6",
            "run7","run8","run9","run10","run11","run12","run13","run14","run15",});
        private int runFrame = 0;
        
        private List<string> zapperFrames = new List<string>(new String[] { "Zapper1", "Zapper2", "Zapper3", "Zapper4" });
        private int currFrame = 0;

        private List<string> coinFrames = new List<string>(new String[] { "moeda1", "moeda2", "moeda3", "moeda4",
        "moeda5", "moeda6"});
        private int coinFrame = 0;

        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                gravity = -7;
                carl.Image = Properties.Resources.flying_frame;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                gravity = 7;
                carl.Image = Properties.Resources.idle_frame;
            }
        }

        private void endGame()
        {
            totalCoins = coins;
            gameTimer.Stop();
            DeathScreen deathWindow = new DeathScreen();
            deathWindow.ShowDialog();
            deathWindow = null;
            this.Close();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            background_move();
            carl.Top += gravity;
            carlCollider.Top += gravity;
            coinText.Text = "Coins: " + coins;
            distance += 1;
            distanceText.Text = distance + "m";

            if(death == true)
            {
                endGame();
            }

            if (carl.Top <= 3)
            {
                carl.Top = 3;
                carlCollider.Top = 3;
            }
            
            if(carl.Bounds.IntersectsWith(ground.Bounds))
            {
                carl.Top = ground.Top - carl.Height;
                carlCollider.Top = ground.Top - carlCollider.Height - 20;

                runFrame = (runFrame + 1) % runFrames.Count();
                Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(runFrames[runFrame]);
                carl.Image = bmp;
            }

            foreach(PictureBox z in zapper)
            {
                z.Left -= gameSpeed;
                if (carlCollider.Bounds.IntersectsWith(z.Bounds))
                {
                    death = true;
                }
            }

            foreach(PictureBox c in coin)
            {
                if(c.Visible == true)
                {
                    c.Left -= gameSpeed;
                    if (carlCollider.Bounds.IntersectsWith(c.Bounds))
                    {
                        coins += 1;
                        c.Visible = false;
                    }
                }
            }

            if (distance > dist)
            {
                dist += 250;
                gameSpeed += 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carlCollider.SendToBack();
            carl.Image = Properties.Resources.idle_frame;
            ground.BackColor = Color.Transparent;
        }

        public void animationTimer_Tick(object sender, EventArgs e)
        {
            currFrame = (currFrame + 1) % zapperFrames.Count();
            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(zapperFrames[currFrame]);
            foreach(PictureBox z in zapper)
            {
                z.Image = bmp;
            }
            coinFrame = (coinFrame + 1) % coinFrames.Count();
            Bitmap bmp2 = (Bitmap)Properties.Resources.ResourceManager.GetObject(coinFrames[coinFrame]);
            foreach (PictureBox c in coin)
            {
                c.Image = bmp2;
            }
        }


        private void zapperTimer_Tick(object sender, EventArgs e)
        {
            generateZapper();
        }
        private void generateCoin()
        {
            PictureBox newPic = new PictureBox();
            newPic.SizeMode = PictureBoxSizeMode.StretchImage;
            newPic.Height = 20;
            newPic.Width = 20;
            newPic.Image = Properties.Resources.moeda1;
            newPic.BackColor = Color.Transparent;

            int y = rnd.Next(12, 379);
            newPic.Location = new Point(820, y);
            coin.Add(newPic);
            this.Controls.Add(newPic);
            newPic.BringToFront();
        }
        private void generateZapper()
        {
            PictureBox newZap = new PictureBox();
            newZap.SizeMode = PictureBoxSizeMode.StretchImage;
            newZap.Height = 110;
            newZap.Width = 45;
            newZap.Image = Properties.Resources.Zapper1;
            newZap.BackColor = Color.Transparent;

            int y = rnd.Next(12, 379 - newZap.Height);
            newZap.Location = new Point(820, y);
            zapper.Add(newZap);
            this.Controls.Add(newZap);
            newZap.BringToFront();
        }

        //background
        Image layer1 = Properties.Resources.background;
        int b1 = 0, b2 = 900;
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer1, b1, 0);
            e.Graphics.DrawImage(layer1, b2, 0);
        }

        private void coinTimer_Tick(object sender, EventArgs e)
        {
            generateCoin();
        }

        void background_move()
        {
            if(b1 < -927)
            {
                b1 = 920;
            }
            b1 -= 3;
            b2 -= 3;
            if (b2 < -927)
            {
                b2 = 920;
            }
            Invalidate();
        }
    }
}
