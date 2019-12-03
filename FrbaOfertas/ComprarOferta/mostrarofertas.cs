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
            string instruccion = string.Format("select oferta_descripcion from oferta where");
            ofertas.DataSource = utilidades.ejecutar(instruccion).Tables[0];
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ofertas.SelectedItem.ToString()))
            {
                string instruccion = string.Format("select * from ofertas where oferta= '{0}'",ofertas.SelectedItem.ToString());
                DataSet m = utilidades.ejecutar(instruccion);
                precio.Text = m.Tables[0].Rows[0][""].ToString();
                maximo.Text = m.Tables[0].Rows[0][""].ToString();
                codigo.Text = m.Tables[0].Rows[0][""].ToString();
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
                    ofertasagregadas.Rows.Add(codigo.Text, ofertas.SelectedItem, precio.Text, cantidad,Text);
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
                    else
                    {
                        ofertasagregadas.Rows.Add(codigo.Text, ofertas.SelectedItem, precio.Text, cantidad.Text);
                        double importe = Convert.ToDouble(ofertasagregadas.Rows[contador_fila].Cells[2].Value) * Convert.ToDouble(ofertasagregadas.Rows[contador_fila].Cells[3].Value);
                        ofertasagregadas.Rows[contador_fila].Cells[4].Value = importe;
                        contador_fila++;
                    }
                }
                total = 0;
                foreach(DataGridViewRow fila in ofertasagregadas.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
                total1.Text = total.ToString();                
            }
            string instruccion = string.Format("select * from ofertas where ofertas ='{0}'");
            DataSet m = utilidades.ejecutar(instruccion);
            
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
    }
}
