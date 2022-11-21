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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        private void backToMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            totalCoinsText.Text = "" + Game.totalCoins;
            coin.Image = Properties.Resources.moeda1;
        }

        private void coin_Click(object sender, EventArgs e)
        {

        }
    }
}
