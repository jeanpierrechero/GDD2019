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
using System.Collections;

namespace FrbaOfertas.AbmProveedor
{
    public partial class edit : Form
    {
        private Proveedor _proveedor;
        private Session _session;

        public edit(Proveedor proveedor,Session session)
        {
            _proveedor = proveedor;
            _session = session;
            InitializeComponent();
            llenar_combo_ciudad();
            cargarDatos();
            cargarRubros();
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
            razonsocial.Text = _proveedor.razon_social;
            cuit.Text = _proveedor.cuit;
            direccion.Text = _proveedor.domicilio;
            ciudad.SelectedValue = _proveedor.ciudad;
            telefono.Text = _proveedor.telefono;
            mail.Text = _proveedor.mail;
        }

        public void cargarRubros() {
            string instruccion = string.Format("select rubro_id,rubro_nombre from CRISPI.Rubro");
            DataSet ds = utilidades.ejecutar(instruccion);
            rubros.DataSource = ds.Tables[0];
            rubros.DisplayMember = "rubro_nombre";
            rubros.ValueMember = "rubro_id";

        }

        private void guardar_Click(object sender, EventArgs e)
        {

            string instruccion = string.Format("EXEC CRISPI.proc_update_proveedor '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                 cuit.Text.Trim(), razonsocial.Text.Trim(), direccion.Text.Trim(), mail.Text.Trim(), ciudad.Text.Trim(), 
                 telefono.Text.Trim(),_proveedor.id);
            utilidades.ejecutar(instruccion);
            
            List<int> lista = new List<int>();
            for (int i = 0; i < rubros.CheckedItems.Count; i++)
            {
                DataRow r;
                r = ((DataRowView)this.rubros.CheckedItems[i]).Row;
                lista.Add(Convert.ToInt32(r[this.rubros.ValueMember].ToString()));
                r = null;
            }

            this.updateRubrosProveedores(lista);

            MessageBox.Show("guardado");
            AbmProveedor.listado listado = new AbmProveedor.listado(_session);
            this.Hide();
            listado.Show();
        }

        public void updateRubrosProveedores(List<int> lista) {

            string instruccion = string.Format("delete from CRISPI.Rubro_Proveedor where rubro_proveedor = '{0}'", _proveedor.id);
            utilidades.ejecutar(instruccion);

            foreach (int rubro in lista)
            {
                string instruccion_update = string.Format("EXEC CRISPI.proc_insert_rol_proveedor '{0}','{1}'", rubro, _proveedor.id);
                utilidades.ejecutar(instruccion_update);
            }
        }

    }
}
