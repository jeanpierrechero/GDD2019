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
    public partial class listado : Form
    {
        private DataSet ds;
        public listado()
        {
            InitializeComponent();
            index();
        }

        public void index()
        {
            try
            {
                string instruccion = string.Format("select * from CRISPI.view_clientes");
                ds = utilidades.ejecutar(instruccion);
                dgv_listado.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = string.Format("cliente_nombre LIKE '%{0}%'", lnombre.Text.Trim());
                dv.RowFilter = string.Format("cliente_apellido LIKE '%{0}%'", lapellido.Text.Trim());
                dv.RowFilter = string.Format("CONVERT(VARCHAR(8),cliente_dni) LIKE '%{0}%'", ldni.Text.Trim());
                dv.RowFilter = string.Format("cliente_mail LIKE '%{0}%'", lmail.Text.Trim());
                dgv_listado.DataSource = dv;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
