using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using conexionsql;
using FrbaOfertas.Models;

namespace FrbaOfertas
{
    public partial class contenedor : Form
    {
        private int childFormNumber = 0;
        private Session sesion;

        public contenedor(Session session)
        {
            InitializeComponent(session);
            this.sesion = session;
        }
        
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmCliente.nuevo nuevocliente = new AbmCliente.nuevo();
            nuevocliente.MdiParent = this;
            nuevocliente.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmProveedor.nuevoproveedor proveedor = new AbmProveedor.nuevoproveedor();
            proveedor.MdiParent = this;
            proveedor.Show();

        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarOferta.ofertas ofertanueva = new ComprarOferta.ofertas(sesion);
            ofertanueva.MdiParent = this;
            ofertanueva.Show();
        }

        private void contenedor_Load(object sender, EventArgs e)
        {

        }


        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar.Form1 a = new Facturar.Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarOferta.mostrarofertas a = new ComprarOferta.mostrarofertas(sesion);
            a.MdiParent = this;
            a.Show();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            a.MdiParent = this;
            a.Show();
        }

        private void listadoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmCliente.listado listado = new AbmCliente.listado(sesion);
            listado.MdiParent = this;
            listado.Show();
        }

        private void listadoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmProveedor.listado listado = new AbmProveedor.listado(sesion);
            listado.MdiParent = this;
            listado.Show();

        }

    }
}
