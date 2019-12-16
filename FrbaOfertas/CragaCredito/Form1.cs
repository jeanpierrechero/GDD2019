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

namespace FrbaOfertas.CragaCredito
{
    public partial class datos : Form
    {
        private Session sesion;
        public datos(Session session)
        {
            InitializeComponent();
            this.sesion = session;
        }

        private void datos_Load(object sender, EventArgs e)
        {
            string instruccion = string.Format("select tipo_pago_id,tipo_pago_nombre from CRISPI.Tipo_pago");
            tipo.DataSource = utilidades.ejecutar(instruccion).Tables[0];
            tipo.DisplayMember = "tipo_pago_nombre";
            tipo.ValueMember = "tipo_pago_id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string instruccion = string.Format("exec CRISPI.proc_cargar_credito '{0}','{1}','{2}','{3}','{4}'",sesion.cliente_id.ToString(),tipo.SelectedValue.ToString(),errorbox1.Text,errorbox2.Text,tarjeta.Text);
            utilidades.ejecutar(instruccion);

        }
    }
}
