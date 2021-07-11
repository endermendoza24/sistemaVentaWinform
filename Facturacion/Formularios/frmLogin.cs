using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Logica;
using Facturacion.Datos;
using Facturacion.Formularios;


namespace Facturacion.Seguridad
{
    public partial class frmLogin : Form
    {
        //  Instancias de las clases
        
        clsValidacionUsuario vali = new clsValidacionUsuario();
        clsConexion cone = new clsConexion();
        frmInicio fr = new frmInicio();
   
        

        public void logueo()
        {
            DataTable data = new DataTable();
            vali.Usuario = txtUser.Text;
            vali.Password = txtPass.Text;
            data = cone.validacion(vali);
            if(data.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + data.Rows[0][0].ToString(), "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fr.ShowDialog();

                frmLogin login = new frmLogin();
                login.ShowDialog();
                if(login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new frmInicio());
                }
                txtPass.Clear();
                txtUser.Clear();
                fr.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecta", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '.')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '.';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logueo();
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
