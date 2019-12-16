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

namespace FrbaOfertas.Facturar
{
    public partial class Form1 : Form
    {
        public DataSet ds;
        public Form1()
        {
            InitializeComponent();
            inicializarFecha();
            //index();
        }

        public void inicializarFecha()
        {
            fecha_inicio.CustomFormat = " ";
            fecha_inicio.Format = DateTimePickerFormat.Custom;

            fecha_fin.CustomFormat = " ";
            fecha_fin.Format = DateTimePickerFormat.Custom;
        }

        private void proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string instruccion = string.Format("select distinct razon_social from CRISPI.view_proveedores");
            DataSet ds = utilidades.ejecutar(instruccion);
            proveedores.DataSource = ds.Tables[0].DefaultView;
            proveedores.ValueMember = "razon_social";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float monto = 0;
            string instruccion = string.Format("exec CRISPI.mostrar_ofertas_vendidad '{0}','{1}','{2}'", proveedores.Text.Trim(),fecha_inicio.Text.Trim(), fecha_fin.Text.Trim());
            ds = utilidades.ejecutar(instruccion);
            dgv_ofertas.DataSource = ds.Tables[0].DefaultView;
            dgv_ofertas.Columns["proveedor_id"].Visible = false;

            string a = string.Format("select CRISPI.func_monto_factura('{0}','{1}','{2}')", proveedores.Text.Trim(), fecha_inicio.Text.Trim(), fecha_fin.Text.Trim());
            DataSet m = utilidades.ejecutar(a);
            monto = Convert.ToInt32(m.Tables[0].Rows[0][0]);
            lbl_monto.Text = monto.ToString();
        }

        private void fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            fecha_inicio.CustomFormat = "yyyy-MM-dd";
            fecha_inicio.Format = DateTimePickerFormat.Custom;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicializarFecha();
            proveedores.Text = "";
        }

        private void fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            fecha_fin.CustomFormat = "yyyy-MM-dd";
            fecha_fin.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.facturar '{0}','{1}','{2}'", proveedores.Text.Trim(), fecha_inicio.Text.Trim(), fecha_fin.Text.Trim());
            ds = utilidades.ejecutar(instruccion);
            MessageBox.Show("Ya se generó la factura para el proveedor " + proveedores.Text.Trim());
        }
    }
}
