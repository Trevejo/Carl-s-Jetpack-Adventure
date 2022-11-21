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
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();
        }

        private void backToMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeathScreen_Load(object sender, EventArgs e)
        {
            coinsText.Text = "Coins: " + Game.totalCoins;
        }
    }
}
