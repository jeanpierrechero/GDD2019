using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using conexionsql;

namespace FrbaOfertas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static String u;

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            int valor = 0;
            try
            {
                string a = string.Format("select CRISPI.func_login('{0}','{1}')", tusuario.Text.Trim(), tcontraseña.Text.Trim());
                DataSet m = utilidades.ejecutar(a);
                valor = Convert.ToInt32(m.Tables[0].Rows[0][0].ToString());
                if (valor == 1)
                {
                 
                    if (Convert.ToBoolean(cadministrador.Checked))
                    {
                        contenedor n = new contenedor();
                        this.Hide();
                        n.Show();
                    }
                    else
                    {
                        contenedor u2 = new contenedor();
                        this.Hide();
                        u2.Show();
                    }
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("usuario o contraseña incorrecto");
            }
        
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
