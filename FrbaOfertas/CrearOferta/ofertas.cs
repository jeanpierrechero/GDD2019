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
namespace FrbaOfertas.ComprarOferta
{
    public partial class ofertas : Form
    {
        private string oferta_id;
        private Boolean a=false;
        private Session sesion;
        public ofertas(Session session)
        {
            InitializeComponent();
            this.sesion = session;
        }

        private void ofertas_Load(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.proc_mostrar_rubro");
            rubro.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            rubro.DisplayMember = "rubro_nombre";
            rubro.ValueMember = "rubro_id";
            string instruccion1 = string.Format("exec CRISPI.proc_mostrar_proveedor");
            rs.DataSource = utilidades.ejecutar(instruccion1).Tables[0];
            rs.DisplayMember = "proveedor_rs";
            rs.ValueMember = "proveedor_id";
            mostrar(sesion);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                try
                {
                    string instruccion = String.Format("select r.rubro_proveedor_id from CRISPI.Rubro_Proveedor r  where r.rubro_id='{0}' and r.rubro_proveedor='{1}'", rubro.SelectedValue.ToString(),rs.SelectedValue.ToString());
                    if (string.IsNullOrEmpty(utilidades.ejecutar(instruccion).Tables[0].Rows[0]["rubro_proveedor_id"].ToString()) == false) 
                    {
                        string instruccion9 = String.Format("exec CRISPI.proc_create_oferta '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}'", oferta.Text.Trim(), descripcion.Text.Trim(), precio.Text.Trim(), preciolista.Text.Trim(), fechainicio.Text.Trim(), fechafin.Text.Trim(), cantidad.Text.Trim(), maximo.Text.Trim(),rs.SelectedValue.ToString(),sesion.id.ToString(), rubro.SelectedValue.ToString());
                        utilidades.ejecutar(instruccion9);
                        MessageBox.Show("insertado");
                        mostrar(sesion);
                    }
                    else
                    {
                        MessageBox.Show("error en rubro seleccionar otro");
                    }
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
                string instruccion1 = String.Format("select r.rubro_proveedor_id from CRISPI.Rubro_Proveedor r  where r.rubro_id='{0}' and r.rubro_proveedor='{1}'", rubro.SelectedValue.ToString(), rs.SelectedValue.ToString());
                if (string.IsNullOrEmpty(utilidades.ejecutar(instruccion1).Tables[0].Rows[0]["rubro_proveedor_id"].ToString()) == false)
                {
                    string instruccion = String.Format("exec CRISPI.proc_actualizar_oferta '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'", oferta_id, oferta.Text.Trim(), descripcion.Text.Trim(),Convert.ToDouble( precio.Text).ToString(),Convert.ToDouble( preciolista.Text).ToString(), fechainicio.Text.Trim(), fechafin.Text.Trim(), cantidad.Text.Trim(), maximo.Text.Trim(), rs.SelectedValue.ToString(), sesion.id.ToString(), rubro.SelectedValue.ToString());
                    utilidades.ejecutar(instruccion);
                    MessageBox.Show("insertado");
                    mostrar(sesion);
                    a = false;
                }
                else
                {
                    MessageBox.Show("error en rubro seleccionar otro");
                }
                }
                catch
                {
                  MessageBox.Show("error ");
                }
            }
        }
      
        public void mostrar(Session a)
        {
            if (sesion.proveedor_id != 0)
            {
                string instruccion = String.Format("exec CRISPI.proc_ofertas '{0}'",a.proveedor_id);
                dataGridView1.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            }
            else
            {
                string instruccion = String.Format("select * from CRISPI.Oferta");
                dataGridView1.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            }
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
                string instruccion = string.Format("select * from CRISPI.Rubro_Proveedor s join CRISPI.Rubro r on s.rubro_id=r.rubro_id join CRISPI.Proveedor p on s.rubro_proveedor=p.proveedor_id  where rubro_proveedor_id='{0}'", dataGridView1.CurrentRow.Cells["oferta_rubro_proveedor_id"].Value.ToString());
                DataSet m = utilidades.ejecutar(instruccion);
                rs.Text = m.Tables[0].Rows[0]["proveedor_rs"].ToString();
                rubro.Text = m.Tables[0].Rows[0]["rubro_nombre"].ToString();
               
            }
        }

        private void eliminaroferta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                oferta_id = dataGridView1.CurrentRow.Cells["oferta_id"].Value.ToString();
                string instruccion = string.Format("exec CRISPI.proc_eliminar_oferta '{0}'", oferta_id);
                utilidades.ejecutar(instruccion);
                mostrar(sesion);
            }
        }
    }
}
