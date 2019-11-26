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
    public partial class eliminarcliente : Form
    {
        public eliminarcliente()
        {
            InitializeComponent();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string instruccion = string.Format("EXEC  '{0}','{1}'", cliente.Text.Trim(), numero.Text.Trim());
                utilidades.ejecutar(instruccion);
                MessageBox.Show("eliminado");

            }
            catch
            {
                MessageBox.Show("ocurrio error");
            }
        }
    }
}
