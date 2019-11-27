﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexionsql;
namespace FrbaOfertas.AbmProveedor
{
    public partial class eliminarproveedor : Form
    {
        public eliminarproveedor()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (utilidades.chequearformulario(this, errorProvider1) == false)
            {
                try
                {
                    string instruccion = string.Format("EXEC  '{0}','{1}'", proveedoreliminar.Text.Trim(), numero.Text.Trim());
                    utilidades.ejecutar(instruccion);
                    MessageBox.Show("eliminado");

                }
                catch
                {
                    MessageBox.Show("ocurrio error");
                }
            }
        }

        private void eliminarproveedor_Load(object sender, EventArgs e)
        {

        }

        private void proveedoreliminar_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}