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
            index();
        }

        public void index() {
            string instruccion = string.Format("select * from CRISPI.ofertas_facturas");
            ds = utilidades.ejecutar(instruccion);
            dgv_ofertas.DataSource = ds.Tables[0].DefaultView;
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
    }
}
