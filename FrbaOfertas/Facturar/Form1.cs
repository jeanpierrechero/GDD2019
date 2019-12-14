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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.facturar '{0}','{1}'", cliente.Text, fecha.Text);
            utilidades.ejecutar(instruccion);

        }
    }
}
