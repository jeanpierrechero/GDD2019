namespace FrbaOfertas.CragaCredito
{
    partial class datos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorbox1 = new conexionsql.errorbox();
            this.tarjeta = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.errorbox2 = new conexionsql.errorbox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "tipo pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "datos";
            // 
            // errorbox1
            // 
            this.errorbox1.chequear = false;
            this.errorbox1.Location = new System.Drawing.Point(252, 58);
            this.errorbox1.Name = "errorbox1";
            this.errorbox1.Size = new System.Drawing.Size(204, 22);
            this.errorbox1.TabIndex = 4;
            // 
            // tarjeta
            // 
            this.tarjeta.Location = new System.Drawing.Point(252, 106);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(204, 22);
            this.tarjeta.TabIndex = 5;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(252, 164);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(204, 24);
            this.tipo.TabIndex = 6;
            // 
            // errorbox2
            // 
            this.errorbox2.chequear = false;
            this.errorbox2.Location = new System.Drawing.Point(252, 229);
            this.errorbox2.Name = "errorbox2";
            this.errorbox2.Size = new System.Drawing.Size(204, 22);
            this.errorbox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorbox2);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.tarjeta);
            this.Controls.Add(this.errorbox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "datos";
            this.Text = "carga credito";
            this.Load += new System.EventHandler(this.datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private conexionsql.errorbox errorbox1;
        private System.Windows.Forms.TextBox tarjeta;
        private System.Windows.Forms.ComboBox tipo;
        private conexionsql.errorbox errorbox2;
        private System.Windows.Forms.Button button1;
    }
}