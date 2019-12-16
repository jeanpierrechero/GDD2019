namespace FrbaOfertas.ComprarOferta
{
    partial class ofertas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eliminaroferta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.rs = new System.Windows.Forms.ComboBox();
            this.maximo = new conexionsql.errorbox();
            this.cantidad = new conexionsql.errorbox();
            this.fechafin = new conexionsql.errorbox();
            this.fechainicio = new conexionsql.errorbox();
            this.preciolista = new conexionsql.errorbox();
            this.precio = new conexionsql.errorbox();
            this.descripcion = new conexionsql.errorbox();
            this.oferta = new conexionsql.errorbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo oferta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 319);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(848, 222);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(451, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "preciolista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "fecha inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(377, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "fecha fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(560, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "maximo";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guardar.Location = new System.Drawing.Point(43, 250);
            this.guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(81, 24);
            this.guardar.TabIndex = 19;
            this.guardar.Text = "guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(175, 562);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminaroferta
            // 
            this.eliminaroferta.BackColor = System.Drawing.Color.Green;
            this.eliminaroferta.ForeColor = System.Drawing.Color.White;
            this.eliminaroferta.Location = new System.Drawing.Point(43, 562);
            this.eliminaroferta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminaroferta.Name = "eliminaroferta";
            this.eliminaroferta.Size = new System.Drawing.Size(98, 32);
            this.eliminaroferta.TabIndex = 21;
            this.eliminaroferta.Text = "eliminar";
            this.eliminaroferta.UseVisualStyleBackColor = false;
            this.eliminaroferta.Click += new System.EventHandler(this.eliminaroferta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MintCream;
            this.label9.Location = new System.Drawing.Point(9, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "listaofertas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "razon social";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(508, 213);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "rubro";
            // 
            // rubro
            // 
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(582, 207);
            this.rubro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(113, 21);
            this.rubro.TabIndex = 28;
            // 
            // rs
            // 
            this.rs.FormattingEnabled = true;
            this.rs.Location = new System.Drawing.Point(133, 204);
            this.rs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(150, 21);
            this.rs.TabIndex = 29;
            // 
            // maximo
            // 
            this.maximo.chequear = false;
            this.maximo.Location = new System.Drawing.Point(625, 67);
            this.maximo.Margin = new System.Windows.Forms.Padding(2);
            this.maximo.Name = "maximo";
            this.maximo.Size = new System.Drawing.Size(92, 20);
            this.maximo.TabIndex = 16;
            // 
            // cantidad
            // 
            this.cantidad.chequear = false;
            this.cantidad.Location = new System.Drawing.Point(133, 71);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(92, 20);
            this.cantidad.TabIndex = 15;
            // 
            // fechafin
            // 
            this.fechafin.chequear = false;
            this.fechafin.Location = new System.Drawing.Point(449, 112);
            this.fechafin.Margin = new System.Windows.Forms.Padding(2);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(180, 20);
            this.fechafin.TabIndex = 12;
            // 
            // fechainicio
            // 
            this.fechainicio.chequear = false;
            this.fechainicio.Location = new System.Drawing.Point(133, 110);
            this.fechainicio.Margin = new System.Windows.Forms.Padding(2);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(180, 20);
            this.fechainicio.TabIndex = 11;
            // 
            // preciolista
            // 
            this.preciolista.chequear = false;
            this.preciolista.Location = new System.Drawing.Point(379, 68);
            this.preciolista.Margin = new System.Windows.Forms.Padding(2);
            this.preciolista.Name = "preciolista";
            this.preciolista.Size = new System.Drawing.Size(102, 20);
            this.preciolista.TabIndex = 10;
            // 
            // precio
            // 
            this.precio.chequear = false;
            this.precio.Location = new System.Drawing.Point(510, 21);
            this.precio.Margin = new System.Windows.Forms.Padding(2);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(139, 20);
            this.precio.TabIndex = 9;
            // 
            // descripcion
            // 
            this.descripcion.chequear = false;
            this.descripcion.Location = new System.Drawing.Point(133, 161);
            this.descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(584, 20);
            this.descripcion.TabIndex = 8;
            // 
            // oferta
            // 
            this.oferta.chequear = false;
            this.oferta.Location = new System.Drawing.Point(133, 21);
            this.oferta.Margin = new System.Windows.Forms.Padding(2);
            this.oferta.Name = "oferta";
            this.oferta.Size = new System.Drawing.Size(239, 20);
            this.oferta.TabIndex = 7;
            // 
            // ofertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(869, 609);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eliminaroferta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maximo);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.fechainicio);
            this.Controls.Add(this.preciolista);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.oferta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ofertas";
            this.Text = "ofertas";
            this.Load += new System.EventHandler(this.ofertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private conexionsql.errorbox oferta;
        private conexionsql.errorbox descripcion;
        private conexionsql.errorbox preciolista;
        private conexionsql.errorbox precio;
        private conexionsql.errorbox fechafin;
        private conexionsql.errorbox fechainicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private conexionsql.errorbox maximo;
        private conexionsql.errorbox cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eliminaroferta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.ComboBox rs;
    }
}