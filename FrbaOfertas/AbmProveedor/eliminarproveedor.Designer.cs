﻿namespace FrbaOfertas.AbmProveedor
{
    partial class eliminarproveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proveedoreliminar = new System.Windows.Forms.TextBox();
            this.proveedor = new System.Windows.Forms.TextBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "codigo";
            // 
            // proveedoreliminar
            // 
            this.proveedoreliminar.Location = new System.Drawing.Point(271, 32);
            this.proveedoreliminar.Name = "proveedoreliminar";
            this.proveedoreliminar.Size = new System.Drawing.Size(186, 22);
            this.proveedoreliminar.TabIndex = 2;
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(271, 76);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(186, 22);
            this.proveedor.TabIndex = 3;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(73, 134);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 4;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // eliminarproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 283);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.proveedor);
            this.Controls.Add(this.proveedoreliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eliminarproveedor";
            this.Text = "eliminarproveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proveedoreliminar;
        private System.Windows.Forms.TextBox proveedor;
        private System.Windows.Forms.Button eliminar;
    }
}