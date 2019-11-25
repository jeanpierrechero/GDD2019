using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexionsql;
namespace FrbaOfertas.AbmProveedor
{
    public partial class nuevoproveedor : Form
    {
        public nuevoproveedor()
        {
            InitializeComponent();
        }

        private void agregarnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string instruccion = string.Format("EXEC CRISPI.proc_create_usuario_proveedor  '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", razonsocial.Text.Trim(), usuario.Text.Trim(), contraseña.Text.Trim(), cuit.Text.Trim(), direccion.Text.Trim(), ciudad.Text.Trim(), telefono.Text.Trim(), mail.Text.Trim());
                utilidades.ejecutar(instruccion);
                MessageBox.Show("guardado");
            }
            catch(Exception error)
            {
                MessageBox.Show("ocurrio error");
            }
        }
    }
}
