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
using FrbaOfertas.Models;

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

                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgv_listado.Columns.Add(btnEliminar);

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgv_listado.Columns.Add(btnEditar);

                dgv_listado.Columns["proveedor_id"].Visible = false;
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
                dv.RowFilter = string.Format("razon_social LIKE '%{0}%' and cuit LIKE '%{1}%' and mail LIKE '%{2}%' "+
                    "ciudad LIKE '%{3}%' and rubro LIKE '%{4}%'", lrazonsocial.Text.Trim(), lcuit.Text.Trim(),lmail.Text.Trim(),
                    lciudad.Text.Trim(),lrubro.Text.Trim());
                dgv_listado.DataSource = dv;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgv_listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_listado.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int proveedor_id = Convert.ToInt32(dgv_listado.CurrentRow.Cells["proveedor_id"].Value.ToString());
                try
                {
                    string instruccion = string.Format("delete from CRISPI.Proveedores where proveedor_id = '{0}'", proveedor_id);
                    DataSet ds = utilidades.ejecutar(instruccion);
                }
                catch (Exception er)
                {
                    MessageBox.Show("El proveedor no puede ser eliminado.");
                }

            }

            if (this.dgv_listado.Columns[e.ColumnIndex].Name == "Editar")
            {
                int proveedor_id = Convert.ToInt32(dgv_listado.CurrentRow.Cells["proveedor_id"].Value.ToString());
                string instruccion = string.Format("select * from CRISPI.view_proveedores where proveedor_id = '{0}'", proveedor_id);
                DataSet ds = utilidades.ejecutar(instruccion);
                Proveedor proveedor = new Proveedor(ds.Tables[0].Rows[0]);
                AbmProveedor.edit form = new AbmProveedor.edit(proveedor);
                this.Hide();
                form.Show();
            }
        }
    }
}
