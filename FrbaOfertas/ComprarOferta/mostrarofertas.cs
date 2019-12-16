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
    public partial class mostrarofertas : Form
    {
        public static int contador_fila=0;
        public static double total ;
        private Session sesion;
        public mostrarofertas(Session session)
        {
            InitializeComponent();
            this.sesion = session;
        }

        private void mostrarofertas_Load(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.proc_mostrar_ofertas");
            ofertas.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            ofertas.DisplayMember = "oferta_descripcion";
            ofertas.ValueMember = "oferta_id";

            string instruccion1 = string.Format("exec CRISPI.proc_mostrar_rubro");
            rubro.DataSource = utilidades.ejecutar(instruccion1).Tables[0];
            rubro.DisplayMember = "rubro_nombre";
            rubro.ValueMember = "rubro_id";
            cliente.Text = sesion.cliente_id.ToString();
            


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
            
            

        }

        private void buttoncomprar_Click(object sender, EventArgs e)
        {
            string instruccion1 = string.Format("select cliente_credito from CRISPI.Cliente where cliente_id='{0}'", cliente.Text);
            Double credito = Convert.ToDouble(utilidades.ejecutar(instruccion1).Tables[0].Rows[0]["cliente_credito"].ToString());
            Double monto=Convert.ToDouble(total1.Text);


            if (credito >= monto)
            {
                Double c = credito - monto;

                string instruccion = string.Format("exec CRISPI.proc_comprar_oferta '{0}','{1}','{2}','{3}','{4}'", ofertas.SelectedValue.ToString(), cliente.Text, errorbox2.Text, cantidad.Text,c.ToString());
                utilidades.ejecutar(instruccion);
                MessageBox.Show("compra correcta ");
                codigo.Text = "";
                precio.Text = "";
                maximo.Text = "";
                cantidad.Text = "";
                total1.Text = "";
                ofertasagregadas.Rows.RemoveAt(0);
                
            }
            else
            {
                MessageBox.Show("credito insuficiente");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string instruccion = string.Format("select oferta_id,oferta_descripcion from CRISPI.Oferta s join CRISPI.Rubro_Proveedor p on s.oferta_rubro_proveedor_id=p.rubro_proveedor_id join CRISPI.Rubro r on p.rubro_id=r.rubro_id where r.rubro_id='{0}'", rubro.SelectedValue.ToString());
            ofertas.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            ofertas.DisplayMember = "oferta_descripcion";
            ofertas.ValueMember = "oferta_id";

        }
    }
}
