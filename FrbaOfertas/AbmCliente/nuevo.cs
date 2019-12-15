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

namespace FrbaOfertas.AbmCliente
{
    public partial class nuevo : Form
    {
        public nuevo()
        {
            InitializeComponent();
            llenar_combo_ciudad();
            inicializarFecha();
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

        public void inicializarFecha()
        {
            nuevofecha.CustomFormat = " ";
            nuevofecha.Format = DateTimePickerFormat.Custom;
        }

        private void agregarnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                bool estado = check_estado.Checked;
                int tipo_estado = 0;
                if (estado) {
                    tipo_estado = 1;
                }
                string instruccion = string.Format("EXEC CRISPI.proc_create_usuario_cliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'", nuevonombre.Text.Trim(), nuevoapellido.Text.Trim(), nuevousuario.Text.Trim(),
                    nuevocontraseña.Text.Trim(), nuevofecha.Text.Trim(), nuevodni.Text.Trim(), nuevodireccion.Text.Trim(), ciudad.Text.Trim(), nuevocodigo.Text.Trim(), nuevotelefono.Text.Trim(), nuevomail.Text.Trim(), tipo_estado);
                utilidades.ejecutar(instruccion);
                MessageBox.Show("guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void nuevofecha_ValueChanged(object sender, EventArgs e)
        {
            nuevofecha.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            nuevofecha.Format = DateTimePickerFormat.Custom; 
        }
    }
}
