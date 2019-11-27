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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string instruccion = string.Format("EXEC CRISPI.proc_create_usuario_cliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'", nuevonombre.Text.Trim(), nuevoapellido.Text.Trim(), nuevousuario.Text.Trim(),
                    nuevocontraseña.Text.Trim(), nuevofecha.Text.Trim(), nuevodni.Text.Trim(), nuevodireccion.Text.Trim(), nuevociudad.Text.Trim(), nuevocodigo.Text.Trim(),nuevotelefono.Text.Trim(), nuevomail.Text.Trim());
                utilidades.ejecutar(instruccion);
                MessageBox.Show("guardado");
            }
            catch (Exception error)
            {
                MessageBox.Show("ocurrio error:");
            }
        }
    }
}
