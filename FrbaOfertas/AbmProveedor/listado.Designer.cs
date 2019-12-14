namespace FrbaOfertas.AbmProveedor
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
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lrazonsocial = new System.Windows.Forms.TextBox();
            this.label_razon = new System.Windows.Forms.Label();
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.lcuit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(29, 115);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 29;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(767, 115);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 28;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lrazonsocial
            // 
            this.lrazonsocial.Location = new System.Drawing.Point(118, 11);
            this.lrazonsocial.Name = "lrazonsocial";
            this.lrazonsocial.Size = new System.Drawing.Size(210, 20);
            this.lrazonsocial.TabIndex = 22;
            // 
            // label_razon
            // 
            this.label_razon.AutoSize = true;
            this.label_razon.Location = new System.Drawing.Point(26, 15);
            this.label_razon.Name = "label_razon";
            this.label_razon.Size = new System.Drawing.Size(70, 13);
            this.label_razon.TabIndex = 16;
            this.label_razon.Text = "Razón Social";
            // 
            // dgv_listado
            // 
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(13, 161);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.Size = new System.Drawing.Size(950, 282);
            this.dgv_listado.TabIndex = 15;
            this.dgv_listado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_CellClick);
            // 
            // lcuit
            // 
            this.lcuit.Location = new System.Drawing.Point(632, 18);
            this.lcuit.Name = "lcuit";
            this.lcuit.Size = new System.Drawing.Size(210, 20);
            this.lcuit.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cuit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mail";
            // 
            // lmail
            // 
            this.lmail.Location = new System.Drawing.Point(118, 44);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(210, 20);
            this.lmail.TabIndex = 25;
            // 
            // listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 455);
            this.Controls.Add(this.lcuit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lmail);
            this.Controls.Add(this.lrazonsocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_razon);
            this.Controls.Add(this.dgv_listado);
            this.Name = "listado";
            this.Text = "listado";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox lrazonsocial;
        private System.Windows.Forms.Label label_razon;
        private System.Windows.Forms.DataGridView dgv_listado;
        private System.Windows.Forms.TextBox lcuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lmail;
    }
}