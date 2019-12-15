namespace FrbaOfertas.Facturar
{
    partial class Form1
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
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dgv_ofertas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ofertas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // proveedores
            // 
            this.proveedores.FormattingEnabled = true;
            this.proveedores.Location = new System.Drawing.Point(141, 85);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(190, 21);
            this.proveedores.TabIndex = 1;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.CustomFormat = "yyyy-MM-dd";
            this.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_inicio.Location = new System.Drawing.Point(141, 22);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(190, 20);
            this.fecha_inicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Fin";
            // 
            // fecha_fin
            // 
            this.fecha_fin.CustomFormat = "yyyy-MM-dd";
            this.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_fin.Location = new System.Drawing.Point(626, 23);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(190, 20);
            this.fecha_fin.TabIndex = 4;
            // 
            // dgv_ofertas
            // 
            this.dgv_ofertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ofertas.Location = new System.Drawing.Point(15, 164);
            this.dgv_ofertas.Name = "dgv_ofertas";
            this.dgv_ofertas.Size = new System.Drawing.Size(878, 230);
            this.dgv_ofertas.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ver Ofertas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ver_ofertas);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Facturar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_ofertas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ofertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.DataGridView dgv_ofertas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}