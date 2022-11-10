﻿namespace ProyectoAutomotriz.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(258, 343);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(241, 19);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "error";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(307, 213);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Usuario.Location = new System.Drawing.Point(185, 211);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(79, 25);
            this.Usuario.TabIndex = 12;
            this.Usuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.Location = new System.Drawing.Point(307, 259);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(143, 20);
            this.txtContraseña.TabIndex = 9;
            // 
            // Contraseña
            // 
            this.Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contraseña.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Contraseña.Location = new System.Drawing.Point(150, 257);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(114, 25);
            this.Contraseña.TabIndex = 10;
            this.Contraseña.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIniciar.Location = new System.Drawing.Point(284, 292);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(189, 35);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(284, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}