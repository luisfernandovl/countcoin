using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountCoin
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tmrSplashScreen.Start();
        }

        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            if (panelSlide.Width > 652)
            {
                panelSlide.Width = 0;
            }
            if (panelSlide.Width < 652)
            {
                panelSlide.Width += 3;
            }
            if (panelSlide.Width == 652)
            {
                frmLogin Login = new frmLogin(this);
                Login.Show();
                this.Hide();
                tmrSplashScreen.Enabled = false;
            }
            else
                return;
        }
    }
}
