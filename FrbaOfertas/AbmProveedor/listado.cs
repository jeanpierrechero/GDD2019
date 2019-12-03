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
    public partial class listado : Form
    {
        private DataSet ds;
        public listado()
        {
            InitializeComponent();
            index();
            llenar_combo_ciudad();
            llenar_combo_rubro();
        }

        public void index()
        {
            try
            {
                string instruccion = string.Format("select * from CRISPI.view_proveedores");
                ds = utilidades.ejecutar(instruccion);
                dgv_listado.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void llenar_combo_ciudad()
        {
            try
            {
                string instruccion = string.Format("select ciudad_id,ciudad_nombre from CRISPI.Ciudad");
                DataSet ds = utilidades.ejecutar(instruccion);
                lciudad.DataSource = ds.Tables[0].DefaultView;
                lciudad.ValueMember = "ciudad_nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void llenar_combo_rubro()
        {
            try
            {
                string instruccion = string.Format("select rubro_id,rubro_nombre from CRISPI.Rubro");
                DataSet ds = utilidades.ejecutar(instruccion);
                lrubro.DataSource = ds.Tables[0].DefaultView;
                lrubro.ValueMember = "rubro_nombre";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = string.Format("razon_social LIKE '%{0}%'", lrazonsocial.Text.Trim());
                dv.RowFilter = string.Format("cuit LIKE '%{0}%'", lcuit.Text.Trim());
                dv.RowFilter = string.Format("mail LIKE '%{0}%'", lmail.Text.Trim());
                dv.RowFilter = string.Format("ciudad LIKE '%{0}%'", lciudad.Text.Trim());
                dv.RowFilter = string.Format("rubro LIKE '%{0}%'", lrubro.Text.Trim());
                dgv_listado.DataSource = dv;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
