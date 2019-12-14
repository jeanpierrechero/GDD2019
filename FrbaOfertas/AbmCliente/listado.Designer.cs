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
            this.lnombre = new System.Windows.Forms.TextBox();
            this.lapellido = new System.Windows.Forms.TextBox();
            this.ldni = new System.Windows.Forms.TextBox();
            this.lmail = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listado
            // 
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(13, 209);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.Size = new System.Drawing.Size(1042, 245);
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
            this.label1.Location = new System.Drawing.Point(631, 19);
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
            this.label3.Location = new System.Drawing.Point(631, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
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
            this.lapellido.Location = new System.Drawing.Point(794, 16);
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
            this.lmail.Location = new System.Drawing.Point(794, 44);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(210, 20);
            this.lmail.TabIndex = 10;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(929, 109);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(29, 109);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 466);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lmail);
            this.Controls.Add(this.ldni);
            this.Controls.Add(this.lapellido);
            this.Controls.Add(this.lnombre);
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
        private System.Windows.Forms.TextBox lnombre;
        private System.Windows.Forms.TextBox lapellido;
        private System.Windows.Forms.TextBox ldni;
        private System.Windows.Forms.TextBox lmail;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
    }
}