﻿namespace FrbaOfertas
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuario = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.tusuario = new System.Windows.Forms.TextBox();
            this.tcontraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(47, 45);
            this.usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 19);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "usuario";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(47, 90);
            this.contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(75, 19);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "contraseña";
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iniciar.Location = new System.Drawing.Point(50, 227);
            this.iniciar.Margin = new System.Windows.Forms.Padding(2);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(97, 19);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "iniciar";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salir.Location = new System.Drawing.Point(205, 227);
            this.salir.Margin = new System.Windows.Forms.Padding(2);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(97, 19);
            this.salir.TabIndex = 3;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = false;
            // 
            // tusuario
            // 
            this.tusuario.Location = new System.Drawing.Point(180, 45);
            this.tusuario.Margin = new System.Windows.Forms.Padding(2);
            this.tusuario.Name = "tusuario";
            this.tusuario.Size = new System.Drawing.Size(162, 20);
            this.tusuario.TabIndex = 4;
            // 
            // tcontraseña
            // 
            this.tcontraseña.Location = new System.Drawing.Point(180, 88);
            this.tcontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.tcontraseña.Name = "tcontraseña";
            this.tcontraseña.Size = new System.Drawing.Size(162, 20);
            this.tcontraseña.TabIndex = 5;
            this.tcontraseña.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(423, 331);
            this.Controls.Add(this.tcontraseña);
            this.Controls.Add(this.tusuario);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox tusuario;
        private System.Windows.Forms.TextBox tcontraseña;
    }
}

