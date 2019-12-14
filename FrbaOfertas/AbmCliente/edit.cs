using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Models;
using conexionsql;

namespace FrbaOfertas.AbmCliente
{
    public partial class edit : Form
    {
        private Cliente _cliente;
        private Session _session;

        public edit(Cliente cliente,Session session)
        {
            _cliente = cliente;
            _session = session;
            InitializeComponent();
            llenar_combo_ciudad();
            cargarDatos();
        }

        public void llenar_combo_ciudad()
        {
            try
            {
                string instruccion = string.Format("select ciudad_id,ciudad_nombre from CRISPI.Ciudad");
                DataSet ds = utilidades.ejecutar(instruccion);
                ciudad.DataSource = ds.Tables[0].DefaultView;
                ciudad.ValueMember = "ciudad_nombre";


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void cargarDatos()
        {
            nuevonombre.Text = _cliente.nombre;
            nuevoapellido.Text = _cliente.apellido;
            nuevofecha.Value = _cliente.fecha_nacimiento;
            nuevodni.Text = _cliente.dni;
            nuevodireccion.Text = _cliente.direccion;
            ciudad.SelectedValue = _cliente.ciudad;
            nuevocodigo.Text = _cliente.codigo_postal;
            nuevotelefono.Text = _cliente.telefono;
            nuevomail.Text = _cliente.mail;

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string instruccion = string.Format("EXEC CRISPI.proc_update_cliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'",
                nuevonombre.Text.Trim(), nuevoapellido.Text.Trim(), nuevodni.Text.Trim(), nuevofecha.Text.Trim(), 
                nuevodireccion.Text.Trim(), ciudad.Text.Trim(), nuevomail.Text.Trim(), nuevotelefono.Text.Trim(),
                nuevocodigo.Text.Trim(),_cliente.id);
            utilidades.ejecutar(instruccion);
            MessageBox.Show("guardado");
            AbmCliente.listado listado = new AbmCliente.listado(_session);
            this.Hide();
            listado.Show();
        }

    }
}
