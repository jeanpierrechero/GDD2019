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

namespace FrbaOfertas.AbmCliente
{
    public partial class listado : Form
    {
        private DataSet ds;
        public listado()
        {
            InitializeComponent();
            index();
            inicializarFecha();
            llenar_combo_ciudad();
        }

        public void index()
        {
            try
            {
                string instruccion = string.Format("select * from CRISPI.view_clientes");
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

                dgv_listado.Columns["cliente_id"].Visible = false;

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
                dv.RowFilter = string.Format("cliente_nombre LIKE '%{0}%' and cliente_apellido LIKE '%{1}%' and " + 
                            "cliente_mail LIKE '%{2}%' and Convert(cliente_dni,'System.String') LIKE '%{3}%' and "+
                            "Convert(cliente_telefono,'System.String') LIKE '%{4}%'", 
                            lnombre.Text.Trim(), lapellido.Text.Trim(), lmail.Text.Trim(), ldni.Text.Trim(),
                            ltelefono.Text.Trim());
                dgv_listado.DataSource = dv;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lnombre.Text = "";
            lapellido.Text = "";
            ldni.Text = "";
            lmail.Text = "";
            ltelefono.Text = "";
            lcodigo_postal.Text = "";
            inicializarFecha();
        }

        public void inicializarFecha() {
            lfecha_desde.CustomFormat = " ";
            lfecha_desde.Format = DateTimePickerFormat.Custom;

            lfecha_hasta.CustomFormat = " ";
            lfecha_hasta.Format = DateTimePickerFormat.Custom; 
        }

        private void lfecha_ValueChanged(object sender, EventArgs e)
        {
            lfecha_desde.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            lfecha_desde.Format = DateTimePickerFormat.Custom;

            lfecha_hasta.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            lfecha_hasta.Format = DateTimePickerFormat.Custom; 
        }

        public void llenar_combo_ciudad()
        {
            try
            {
                string instruccion = string.Format("select ciudad_id,ciudad_nombre from CRISPI.Ciudad");
                DataSet ds = utilidades.ejecutar(instruccion);
                lciudad.DataSource = ds.Tables[0].DefaultView;
                lciudad.ValueMember = "ciudad_nombre";
                /*

                DataTable dt = ds.Tables[0];
                DataRow dr = dt.NewRow();
                dr["ciudad_id"] = 0;
                dr["ciudad_nombre"] = "Todos";
                dt.Rows.Add(dr);
                ds.Tables.Add(dt);*/

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgv_listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_listado.Columns[e.ColumnIndex].Name == "Eliminar") {
                int user_id = Convert.ToInt32(dgv_listado.CurrentRow.Cells["cliente_id"].Value.ToString());
                try
                {
                    string instruccion = string.Format("delete from CRISPI.Clientes where cliente_id = '{0}'", user_id);
                    DataSet ds = utilidades.ejecutar(instruccion);
                }
                catch (Exception er)
                {
                    MessageBox.Show("El participante no puede ser eliminado.");
                }
                
            }

            if (this.dgv_listado.Columns[e.ColumnIndex].Name == "Editar")
            {
                int user_id = Convert.ToInt32(dgv_listado.CurrentRow.Cells["cliente_id"].Value.ToString());
                string instruccion = string.Format("select * from CRISPI.view_clientes where cliente_id = '{0}'",user_id);
                DataSet ds = utilidades.ejecutar(instruccion);
                Cliente cliente = new Cliente(ds.Tables[0].Rows[0]);
                AbmCliente.edit form = new AbmCliente.edit(cliente);
                this.Hide();
                form.Show();
            }
        }
    }

}
