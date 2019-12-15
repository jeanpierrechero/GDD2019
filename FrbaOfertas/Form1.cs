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
using FrbaOfertas.Models;

namespace FrbaOfertas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static String u;
        public static int contador=0; 

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
                    if (valor == 1 )
                    {
                        contador = 0;
                   
                        string instruccion = string.Format("select  top 1 * from CRISPI.view_user where username = '{0}'", tusuario.Text.Trim());
                        DataSet ds = utilidades.ejecutar(instruccion);
                        Session session = new Session(ds.Tables[0].Rows[0]);

                        contenedor u2 = new contenedor(session);
                        this.Hide();
                        u2.Show();
                    
                    
                    }
                    else
                    {
                    contador++;
                    if (contador < 3)
                    {
                        MessageBox.Show("error de usuario o contraseña");
                        
                    }
                    else
                    {
                        MessageBox.Show("usuario inabilitado");
                        string p = string.Format("CRISPI.proc_inabilitar '{0}')", tusuario.Text.Trim());
                        utilidades.ejecutar(p);

                    }


                    }
                


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
               
            }
        
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
