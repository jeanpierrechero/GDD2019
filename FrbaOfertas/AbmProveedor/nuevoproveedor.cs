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
            llenar_combo_ciudad();
        }

        public void llenar_combo_ciudad()
        {
            try
            {
                string instruccion = string.Format("select ciudad_id,ciudad_nombre from CRISPI.Ciudad");
                DataSet ds = utilidades.ejecutar(instruccion);
                ciudad.DataSource = ds.Tables[0].DefaultView;
                ciudad.ValueMember = "ciudad_nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void agregarnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string instruccion = string.Format("EXEC CRISPI.proc_create_usuario_proveedor  '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",razonsocial.Text.Trim(), usuario.Text.Trim(), contraseña.Text.Trim(), cuit.Text.Trim(), direccion.Text.Trim(), ciudad.Text.Trim(), telefono.Text.Trim(), mail.Text.Trim());
                utilidades.ejecutar(instruccion);
                MessageBox.Show("guardado");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void nuevoproveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
