namespace FrbaOfertas.ComprarOferta
{
    partial class mostrarofertas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.agragar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofertasagregadas = new System.Windows.Forms.DataGridView();
            this.codigocolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioncolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importecolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoncomprar = new System.Windows.Forms.Button();
            this.ofertas = new System.Windows.Forms.ComboBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.TextBox();
            this.mostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maximo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidad = new conexionsql.errorbox();
            this.label6 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cliente = new conexionsql.errorbox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorbox2 = new conexionsql.errorbox();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasagregadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // agragar
            // 
            this.agragar.BackColor = System.Drawing.Color.Green;
            this.agragar.ForeColor = System.Drawing.Color.White;
            this.agragar.Location = new System.Drawing.Point(880, 384);
            this.agragar.Name = "agragar";
            this.agragar.Size = new System.Drawing.Size(114, 37);
            this.agragar.TabIndex = 0;
            this.agragar.Text = "agregar";
            this.agragar.UseVisualStyleBackColor = false;
            this.agragar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ofertas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "precio";
            // 
            // ofertasagregadas
            // 
            this.ofertasagregadas.AllowUserToAddRows = false;
            this.ofertasagregadas.AllowUserToDeleteRows = false;
            this.ofertasagregadas.AllowUserToResizeColumns = false;
            this.ofertasagregadas.AllowUserToResizeRows = false;
            this.ofertasagregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ofertasagregadas.ColumnHeadersVisible = false;
            this.ofertasagregadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigocolumna,
            this.descripcioncolumna,
            this.preciocolumna,
            this.cantidadcolumna,
            this.importecolumna});
            this.ofertasagregadas.Location = new System.Drawing.Point(57, 421);
            this.ofertasagregadas.Name = "ofertasagregadas";
            this.ofertasagregadas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ofertasagregadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ofertasagregadas.RowHeadersVisible = false;
            this.ofertasagregadas.RowHeadersWidth = 51;
            this.ofertasagregadas.RowTemplate.Height = 24;
            this.ofertasagregadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ofertasagregadas.Size = new System.Drawing.Size(759, 112);
            this.ofertasagregadas.TabIndex = 3;
            // 
            // codigocolumna
            // 
            this.codigocolumna.HeaderText = "codigo";
            this.codigocolumna.MinimumWidth = 6;
            this.codigocolumna.Name = "codigocolumna";
            this.codigocolumna.ReadOnly = true;
            this.codigocolumna.Width = 125;
            // 
            // descripcioncolumna
            // 
            this.descripcioncolumna.HeaderText = "descripcion";
            this.descripcioncolumna.MinimumWidth = 6;
            this.descripcioncolumna.Name = "descripcioncolumna";
            this.descripcioncolumna.ReadOnly = true;
            this.descripcioncolumna.Width = 300;
            // 
            // preciocolumna
            // 
            this.preciocolumna.HeaderText = "precio";
            this.preciocolumna.MinimumWidth = 6;
            this.preciocolumna.Name = "preciocolumna";
            this.preciocolumna.ReadOnly = true;
            this.preciocolumna.Width = 110;
            // 
            // cantidadcolumna
            // 
            this.cantidadcolumna.HeaderText = "cantidad";
            this.cantidadcolumna.MinimumWidth = 6;
            this.cantidadcolumna.Name = "cantidadcolumna";
            this.cantidadcolumna.ReadOnly = true;
            this.cantidadcolumna.Width = 110;
            // 
            // importecolumna
            // 
            this.importecolumna.HeaderText = "importe";
            this.importecolumna.MinimumWidth = 6;
            this.importecolumna.Name = "importecolumna";
            this.importecolumna.ReadOnly = true;
            this.importecolumna.Width = 110;
            // 
            // buttoncomprar
            // 
            this.buttoncomprar.BackColor = System.Drawing.Color.Green;
            this.buttoncomprar.ForeColor = System.Drawing.Color.White;
            this.buttoncomprar.Location = new System.Drawing.Point(880, 503);
            this.buttoncomprar.Name = "buttoncomprar";
            this.buttoncomprar.Size = new System.Drawing.Size(116, 32);
            this.buttoncomprar.TabIndex = 7;
            this.buttoncomprar.Text = "comprar";
            this.buttoncomprar.UseVisualStyleBackColor = false;
            this.buttoncomprar.Click += new System.EventHandler(this.buttoncomprar_Click);
            // 
            // ofertas
            // 
            this.ofertas.FormattingEnabled = true;
            this.ofertas.Location = new System.Drawing.Point(143, 254);
            this.ofertas.Name = "ofertas";
            this.ofertas.Size = new System.Drawing.Size(525, 24);
            this.ofertas.TabIndex = 8;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.Green;
            this.eliminar.ForeColor = System.Drawing.Color.White;
            this.eliminar.Location = new System.Drawing.Point(880, 449);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(114, 31);
            this.eliminar.TabIndex = 9;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(405, 292);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(94, 22);
            this.precio.TabIndex = 10;
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.Color.Green;
            this.mostrar.ForeColor = System.Drawing.Color.White;
            this.mostrar.Location = new System.Drawing.Point(716, 253);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 25);
            this.mostrar.TabIndex = 11;
            this.mostrar.Text = "mostrar";
            this.mostrar.UseVisualStyleBackColor = false;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "cantidadmax";
            // 
            // maximo
            // 
            this.maximo.Location = new System.Drawing.Point(663, 292);
            this.maximo.Name = "maximo";
            this.maximo.Size = new System.Drawing.Size(76, 22);
            this.maximo.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "codigo";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(143, 292);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(140, 22);
            this.codigo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(793, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "cantidad";
            // 
            // cantidad
            // 
            this.cantidad.chequear = false;
            this.cantidad.Location = new System.Drawing.Point(896, 294);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 22);
            this.cantidad.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(660, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "total";
            // 
            // total1
            // 
            this.total1.Location = new System.Drawing.Point(716, 558);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(100, 22);
            this.total1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(140, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "filtro por rubro";
            // 
            // rubro
            // 
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(143, 203);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(201, 24);
            this.rubro.TabIndex = 21;
            this.rubro.SelectedIndexChanged += new System.EventHandler(this.rubro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(58, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "cliente";
            // 
            // cliente
            // 
            this.cliente.chequear = false;
            this.cliente.Location = new System.Drawing.Point(143, 32);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(175, 22);
            this.cliente.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(54, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "cliente2";
            // 
            // errorbox2
            // 
            this.errorbox2.chequear = false;
            this.errorbox2.Location = new System.Drawing.Point(143, 81);
            this.errorbox2.Name = "errorbox2";
            this.errorbox2.Size = new System.Drawing.Size(175, 22);
            this.errorbox2.TabIndex = 25;
            // 
            // mostrarofertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1063, 635);
            this.Controls.Add(this.errorbox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.ofertas);
            this.Controls.Add(this.buttoncomprar);
            this.Controls.Add(this.ofertasagregadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agragar);
            this.Name = "mostrarofertas";
            this.Text = "mostrarofertas";
            this.Load += new System.EventHandler(this.mostrarofertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ofertasagregadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agragar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ofertasagregadas;
        private System.Windows.Forms.Button buttoncomprar;
        private System.Windows.Forms.ComboBox ofertas;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maximo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigocolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioncolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadcolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn importecolumna;
        private conexionsql.errorbox cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.Label label7;
        private conexionsql.errorbox errorbox2;
        private System.Windows.Forms.Label label9;
        private conexionsql.errorbox cliente;
        private System.Windows.Forms.Label label8;
    }
}