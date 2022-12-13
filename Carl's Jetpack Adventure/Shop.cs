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
        bool buyable;
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
            totalCoinsText.Text = "" + Globals.totalCoins;
            coin.Image = Properties.Resources.moeda1;
        }

        private void coin_Click(object sender, EventArgs e)
        {

        }

        private void redSkin_Click(object sender, EventArgs e)
        {
            if (Globals.redCarl)
            {
                buyable = false;
            }
            else
            {
                buyable = true;
            }

            if (Globals.totalCoins >= 100 && buyable == true)
            {
                Globals.totalCoins -= 100;
                Globals.redCarl = true;
                totalCoinsText.Text = "" + Globals.totalCoins;
            }
        }
    }
}
