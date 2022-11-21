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
        public int totalCoins;
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
            totalCoins += Game.totalCoins;
        }
    }
}
