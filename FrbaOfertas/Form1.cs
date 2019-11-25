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
            try
            {
                string a = string.Format("select * from usuario where usuario_username='{0}' and usuario_password='{1}'", usuario.Text.Trim(), contraseña.Text.Trim());
                DataSet m = utilidades.ejecutar(a);
                string cuenta = m.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string c = m.Tables[0].Rows[0]["contraseña"].ToString().Trim();
                u = m.Tables[0].Rows[0]["usuario_id"].ToString().Trim();
                if (cuenta == usuario.Text.Trim() && c == contraseña.Text.Trim())
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
