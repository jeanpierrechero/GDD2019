namespace FrbaOfertas.AbmCliente
{
    partial class listado
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
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.TextBox();
            this.lapellido = new System.Windows.Forms.TextBox();
            this.ldni = new System.Windows.Forms.TextBox();
            this.lmail = new System.Windows.Forms.TextBox();
            this.ltelefono = new System.Windows.Forms.TextBox();
            this.lfecha_desde = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lfecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lcodigo_postal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lciudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listado
            // 
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(13, 209);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.Size = new System.Drawing.Size(869, 247);
            this.dgv_listado.TabIndex = 0;
            this.dgv_listado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(26, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de nacimiento desde";
            // 
            // lnombre
            // 
            this.lnombre.Location = new System.Drawing.Point(178, 12);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(210, 20);
            this.lnombre.TabIndex = 7;
            // 
            // lapellido
            // 
            this.lapellido.Location = new System.Drawing.Point(632, 16);
            this.lapellido.Name = "lapellido";
            this.lapellido.Size = new System.Drawing.Size(210, 20);
            this.lapellido.TabIndex = 8;
            // 
            // ldni
            // 
            this.ldni.Location = new System.Drawing.Point(178, 40);
            this.ldni.Name = "ldni";
            this.ldni.Size = new System.Drawing.Size(210, 20);
            this.ldni.TabIndex = 9;
            // 
            // lmail
            // 
            this.lmail.Location = new System.Drawing.Point(632, 44);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(210, 20);
            this.lmail.TabIndex = 10;
            // 
            // ltelefono
            // 
            this.ltelefono.Location = new System.Drawing.Point(178, 68);
            this.ltelefono.Name = "ltelefono";
            this.ltelefono.Size = new System.Drawing.Size(210, 20);
            this.ltelefono.TabIndex = 11;
            // 
            // lfecha_desde
            // 
            this.lfecha_desde.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.lfecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lfecha_desde.Location = new System.Drawing.Point(178, 102);
            this.lfecha_desde.Name = "lfecha_desde";
            this.lfecha_desde.Size = new System.Drawing.Size(210, 20);
            this.lfecha_desde.TabIndex = 12;
            this.lfecha_desde.Value = new System.DateTime(2019, 2, 18, 0, 0, 0, 0);
            this.lfecha_desde.ValueChanged += new System.EventHandler(this.lfecha_ValueChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(767, 179);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(29, 179);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lfecha_hasta
            // 
            this.lfecha_hasta.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.lfecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lfecha_hasta.Location = new System.Drawing.Point(632, 102);
            this.lfecha_hasta.Name = "lfecha_hasta";
            this.lfecha_hasta.Size = new System.Drawing.Size(210, 20);
            this.lfecha_hasta.TabIndex = 16;
            this.lfecha_hasta.Value = new System.DateTime(2019, 2, 18, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de nacimiento hasta";
            // 
            // lcodigo_postal
            // 
            this.lcodigo_postal.Location = new System.Drawing.Point(632, 74);
            this.lcodigo_postal.Name = "lcodigo_postal";
            this.lcodigo_postal.Size = new System.Drawing.Size(210, 20);
            this.lcodigo_postal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Código postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ciudad";
            // 
            // lciudad
            // 
            this.lciudad.FormattingEnabled = true;
            this.lciudad.Location = new System.Drawing.Point(178, 138);
            this.lciudad.Name = "lciudad";
            this.lciudad.Size = new System.Drawing.Size(210, 21);
            this.lciudad.TabIndex = 21;
            // 
            // listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 468);
            this.Controls.Add(this.lciudad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lcodigo_postal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lfecha_hasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lfecha_desde);
            this.Controls.Add(this.ltelefono);
            this.Controls.Add(this.lmail);
            this.Controls.Add(this.ldni);
            this.Controls.Add(this.lapellido);
            this.Controls.Add(this.lnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dgv_listado);
            this.Name = "listado";
            this.Text = "listado";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listado;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lnombre;
        private System.Windows.Forms.TextBox lapellido;
        private System.Windows.Forms.TextBox ldni;
        private System.Windows.Forms.TextBox lmail;
        private System.Windows.Forms.TextBox ltelefono;
        private System.Windows.Forms.DateTimePicker lfecha_desde;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DateTimePicker lfecha_hasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lcodigo_postal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox lciudad;
    }
}