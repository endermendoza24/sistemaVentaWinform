using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Seguridad;

namespace Facturacion.Formularios
{
    public partial class frmSplashScreen : Form
    {
        public int timeLeft { get; set; }
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timeLeft = 10;
            tmerSplash.Start();
        }

        private void tmerSplash_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width == 700)
            {
                tmerSplash.Stop();                
                frmLogin f2 = new frmLogin();

                f2.Show();

                this.Hide();

            }
        }
    }
}
