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
            mostrar();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                try
                {
                    string instruccion = String.Format("exec '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", oferta.Text.Trim(), descripcion.Text.Trim(), precio.Text.Trim(), preciolista.Text.Trim(), fechainicio.Text.Trim(), fechafin.Text.Trim(), cantidad.Text.Trim(), maximo.Text.Trim());
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
                try
                {
                    string instruccion = String.Format("exec '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'", oferta_id , oferta.Text.Trim(), descripcion.Text.Trim(), precio.Text.Trim(), preciolista.Text.Trim(), fechainicio.Text.Trim(), fechafin.Text.Trim(), cantidad.Text.Trim(), maximo.Text.Trim());
                    utilidades.ejecutar(instruccion);
                    MessageBox.Show("insertado");
                    mostrar();
                    a = false;
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }
        }
        public void mostrar()
        {
            string instruccion = String.Format("select * from oferta");
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
