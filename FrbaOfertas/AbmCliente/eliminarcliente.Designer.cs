namespace FrbaOfertas.AbmCliente
{
    partial class eliminarcliente
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
            this.eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numero = new conexionsql.errorbox();
            this.cliente = new conexionsql.errorbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(92, 151);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 9;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "cliente";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numero
            // 
            this.numero.chequear = true;
            this.numero.Location = new System.Drawing.Point(290, 93);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(186, 22);
            this.numero.TabIndex = 11;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            // 
            // cliente
            // 
            this.cliente.chequear = true;
            this.cliente.Location = new System.Drawing.Point(290, 44);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(186, 22);
            this.cliente.TabIndex = 10;
            this.cliente.TextChanged += new System.EventHandler(this.cliente_TextChanged);
            // 
            // eliminarcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 297);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eliminarcliente";
            this.Text = "eliminarcliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private conexionsql.errorbox cliente;
        private conexionsql.errorbox numero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}