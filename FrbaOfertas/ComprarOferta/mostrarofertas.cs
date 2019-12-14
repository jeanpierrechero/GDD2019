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
    public partial class mostrarofertas : Form
    {
        public static int contador_fila=0;
        public static double total ;
        public mostrarofertas()
        {
            InitializeComponent();
        }

        private void mostrarofertas_Load(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.proc_mostrar_ofertas");
            ofertas.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            ofertas.DisplayMember = "oferta_descripcion";
            ofertas.ValueMember = "oferta_id";
           

            //string instruccion1 = string.Format("select rubro_nombre from CRISPI.Rubro");
            //rubro.DataSource = utilidades.ejecutar(instruccion1).Tables[0].DefaultView;
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ofertas.SelectedItem.ToString())==false)
            {
                string instruccion = string.Format("select * from CRISPI.Oferta where oferta_id='{0}'", ofertas.SelectedValue.ToString().Trim());
                DataSet m = utilidades.ejecutar(instruccion); 
                precio.Text = m.Tables[0].Rows[0]["oferta_precio"].ToString();
                maximo.Text = m.Tables[0].Rows[0]["oferta_maxima"].ToString();
                codigo.Text = m.Tables[0].Rows[0]["oferta_codigo"].ToString();
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (utilidades.chequearformulario(this, errorProvider1) == false)
            {
                Boolean existe = false;
                int numero_fila = 0;
                if (contador_fila == 0)
                {
                    ofertasagregadas.Rows.Add(codigo.Text, ofertas.Text, precio.Text, cantidad.Text);
                    double importe = Convert.ToDouble(ofertasagregadas.Rows[contador_fila].Cells[2].Value) * Convert.ToDouble(ofertasagregadas.Rows[contador_fila].Cells[3].Value);
                    ofertasagregadas.Rows[contador_fila].Cells[4].Value = importe;
                    contador_fila++;
                }
                else
                {
                    foreach(DataGridViewRow fila in ofertasagregadas.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == codigo.Text)
                        {
                            existe = true;
                            numero_fila = fila.Index;
                        }
                    }
                    if (existe)
                    {
                        ofertasagregadas.Rows[numero_fila].Cells[3].Value = (Convert.ToDouble(cantidad.Text) + Convert.ToDouble(ofertasagregadas.Rows[numero_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(ofertasagregadas.Rows[numero_fila].Cells[2].Value) * Convert.ToDouble(ofertasagregadas.Rows[numero_fila].Cells[3].Value);
                        ofertasagregadas.Rows[numero_fila].Cells[4].Value = importe;
                    }
                    //else
                    //{
                      //  ofertasagregadas.Rows.Add(codigo.Text, ofertas.Text, precio.Text, cantidad.Text);
                      //  double importe = Convert.ToDouble(ofertasagregadas.Rows[contador_fila].Cells[2].Value) * Convert.ToDouble(ofertasagregadas.Rows[contador_fila].Cells[3].Value);
                      //  ofertasagregadas.Rows[contador_fila].Cells[4].Value = importe;
                      //  contador_fila++;
                    //}
                }
                total = 0;
                foreach(DataGridViewRow fila in ofertasagregadas.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
                total1.Text = total.ToString();                
            }
            
            
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (contador_fila > 0)
            {
                total = total - Convert.ToDouble(ofertasagregadas.Rows[ofertasagregadas.CurrentRow.Index].Cells[4].Value);
                total1.Text = total.ToString();
                ofertasagregadas.Rows.RemoveAt(ofertasagregadas.CurrentRow.Index);
                contador_fila--;
            }
        }

        private void rubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string instruccion = string.Format("select oferta_descripcion from CRISPI.Oferta join CRISPI.Rubro_Proveedor on oferta_rubro_proveedor=rubro_proveedor_id join CRISPI.Rubro r on rubro_id=r.rubro_id where rubro_id='{0}'",rubro.SelectedValue.ToString());
            ofertas.DataSource = utilidades.ejecutar(instruccion).Tables[0];

        }

        private void buttoncomprar_Click(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI_procedure_comprar_oferta '{0}','{1}','{2}'",ofertas.SelectedValue.ToString(),cliente.Text,errorbox2.Text);
            utilidades.ejecutar(instruccion);
            

        }
    }
}
