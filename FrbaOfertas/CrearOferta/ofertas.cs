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
namespace FrbaOfertas.ComprarOferta
{
    public partial class ofertas : Form
    {
        private string oferta_id;
        private Boolean a=false;
        public ofertas()
        {
            InitializeComponent();
        }

        private void ofertas_Load(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.proc_mostrar_rubro");
            rubro.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            rubro.DisplayMember = "rubro_nombre";
            rubro.ValueMember = "rubro_id";
            mostrar();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                try
                {
                    string instruccion = String.Format("exec CRISPI.proc_create_oferta '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", oferta.Text.Trim(), descripcion.Text.Trim(), precio.Text.Trim(), preciolista.Text.Trim(), fechainicio.Text.Trim(), fechafin.Text.Trim(), cantidad.Text.Trim(), maximo.Text.Trim(),proveedor_id.Text.Trim(),usuario_id.Text.Trim());
                    utilidades.ejecutar(instruccion);
                    MessageBox.Show("insertado");
                    mostrar();
                }
                catch 
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                //try
                //{
                    string instruccion = String.Format("exec CRISPI.proc_actualizar_oferta '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}'", oferta_id , oferta.Text.Trim(), descripcion.Text.Trim(), precio.Text.Trim(), preciolista.Text.Trim(), fechainicio.Text.Trim(), fechafin.Text.Trim(), cantidad.Text.Trim(), maximo.Text.Trim(),proveedor_id.Text.Trim(),usuario_id.Text.Trim());
                    utilidades.ejecutar(instruccion);
                    MessageBox.Show("insertado");
                    mostrar();
                    a = false;
                //}
                //catch
                //{
                  //  MessageBox.Show("error");
                //}
            }
        }
        public void mostrar()
        {
            string instruccion = String.Format("select * from CRISPI.Oferta");
            dataGridView1.DataSource = utilidades.ejecutar(instruccion).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                a = true;
                oferta.Text = dataGridView1.CurrentRow.Cells["oferta_codigo"].Value.ToString();
                descripcion.Text = dataGridView1.CurrentRow.Cells["oferta_descripcion"].Value.ToString();
                precio.Text = dataGridView1.CurrentRow.Cells["oferta_precio"].Value.ToString();
                preciolista.Text = dataGridView1.CurrentRow.Cells["oferta_lista"].Value.ToString();
                fechainicio.Text = dataGridView1.CurrentRow.Cells["oferta_fecha_inicio"].Value.ToString();
                fechafin.Text = dataGridView1.CurrentRow.Cells["oferta_fecha_fin"].Value.ToString();
                cantidad.Text = dataGridView1.CurrentRow.Cells["oferta_cantidad"].Value.ToString();
                maximo.Text = dataGridView1.CurrentRow.Cells["oferta_maxima"].Value.ToString();
                oferta_id = dataGridView1.CurrentRow.Cells["oferta_id"].Value.ToString();
                //proveedor_id.Text = dataGridView1.CurrentRow.Cells["oferta_proveedor_id"].Value.ToString();
                string instruccion = string.Format("select * from CRISPI.Rubro_Proveedor join CRISPI.Rubro r on rubro_id=r.rubro_id where rubro_proveedor_id='{0}'", dataGridView1.CurrentRow.Cells["oferta_rubro_proveedor_id"].Value.ToString());
                DataSet m = utilidades.ejecutar(instruccion);
                proveedor_id.Text = m.Tables[0].Rows[0]["rubro_proveedor"].ToString();
                rubro.Text = m.Tables[0].Rows[0]["rubro_nombre"].ToString();
                usuario_id.Text = dataGridView1.CurrentRow.Cells["oferta_usuario_creador_id"].Value.ToString();
            }
        }

        private void eliminaroferta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                oferta_id = dataGridView1.CurrentRow.Cells["oferta_id"].Value.ToString();
                string instruccion = string.Format("exec '{0}'", oferta_id);
                utilidades.ejecutar(instruccion);
                mostrar();
            }
        }
    }
}
