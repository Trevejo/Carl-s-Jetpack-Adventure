using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_s_Jetpack_Adventure
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            this.Hide();
            Game gameWindow = new Game();
            gameWindow.ShowDialog();
            gameWindow = null;
            highDistText.Font = new Font("Comic Sans", 16, FontStyle.Bold);
            highDistText.Text = "Highest Distance: " + Globals.highDistance;
            this.Show();
        }

        private void openShop(object sender, EventArgs e)
        {
            this.Hide();
            Shop shopWindow = new Shop();
            shopWindow.ShowDialog();
            shopWindow = null;
            this.Show();
        }

        private void exitGame(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }

    public static class Globals
    {
        public static int totalCoins;
        public static int highDistance = 0;
        public static String[] carlRunSkin = new String[15];
        public static Image carlIdleSkin;
        public static Image carlFlySkin;
        public static bool redCarl;
    }
}
