namespace InsightGaming_V1._0
{
    partial class FormLogin
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
            this.btAcceptLogin = new System.Windows.Forms.Button();
            this.btCancelLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.laComprobacionLogin = new System.Windows.Forms.Label();
            this.tbCorreoRecuperacion = new System.Windows.Forms.TextBox();
            this.btEnviarCorreo = new System.Windows.Forms.Button();
            this.pnRecuperarContraseña = new System.Windows.Forms.Panel();
            this.laConfirmacionEnvioContraseña = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.pnRecuperarContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAcceptLogin
            // 
            this.btAcceptLogin.BackColor = System.Drawing.Color.DimGray;
            this.btAcceptLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceptLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcceptLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btAcceptLogin.Location = new System.Drawing.Point(357, 290);
            this.btAcceptLogin.Name = "btAcceptLogin";
            this.btAcceptLogin.Size = new System.Drawing.Size(368, 40);
            this.btAcceptLogin.TabIndex = 4;
            this.btAcceptLogin.Text = "Acceder";
            this.btAcceptLogin.UseVisualStyleBackColor = false;
            this.btAcceptLogin.Click += new System.EventHandler(this.btAcceptLogin_Click);
            // 
            // btCancelLogin
            // 
            this.btCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btCancelLogin.Location = new System.Drawing.Point(357, 336);
            this.btCancelLogin.Name = "btCancelLogin";
            this.btCancelLogin.Size = new System.Drawing.Size(368, 38);
            this.btCancelLogin.TabIndex = 5;
            this.btCancelLogin.Text = "Cancelar";
            this.btCancelLogin.UseVisualStyleBackColor = true;
            this.btCancelLogin.Click += new System.EventHandler(this.btCancelLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pbLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 390);
            this.panel1.TabIndex = 6;
            // 
            // pbLogin
            // 
            this.pbLogin.Location = new System.Drawing.Point(0, 0);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(250, 390);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 8;
            this.pbLogin.TabStop = false;
            this.pbLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogin_MouseDown);
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.BackColor = System.Drawing.Color.DimGray;
            this.tbUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserLogin.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbUserLogin.Location = new System.Drawing.Point(357, 44);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(370, 22);
            this.tbUserLogin.TabIndex = 1;
            this.tbUserLogin.Text = "Usuario";
            this.tbUserLogin.Enter += new System.EventHandler(this.tbUserLogin_Enter);
            this.tbUserLogin.Leave += new System.EventHandler(this.tbUserLogin_Leave);
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.BackColor = System.Drawing.Color.DimGray;
            this.tbPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbPasswordLogin.Location = new System.Drawing.Point(357, 84);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(370, 22);
            this.tbPasswordLogin.TabIndex = 3;
            this.tbPasswordLogin.Text = "Contraseña";
            this.tbPasswordLogin.TextChanged += new System.EventHandler(this.tbPasswordLogin_TextChanged);
            this.tbPasswordLogin.Enter += new System.EventHandler(this.tbPasswordLogin_Enter);
            this.tbPasswordLogin.Leave += new System.EventHandler(this.tbPasswordLogin_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(776, 390);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 357;
            this.lineShape2.X2 = 729;
            this.lineShape2.Y1 = 74;
            this.lineShape2.Y2 = 74;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 359;
            this.lineShape1.X2 = 731;
            this.lineShape1.Y1 = 117;
            this.lineShape1.Y2 = 117;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "¿No tienes Cuenta?";
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistro.Location = new System.Drawing.Point(504, 126);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(80, 21);
            this.lnkRegistro.TabIndex = 9;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "Registrate";
            this.lnkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistro_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(574, 159);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 21);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Pincha aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "¿Has Olvidado la contraseña?";
            // 
            // laComprobacionLogin
            // 
            this.laComprobacionLogin.AutoSize = true;
            this.laComprobacionLogin.BackColor = System.Drawing.Color.DimGray;
            this.laComprobacionLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laComprobacionLogin.ForeColor = System.Drawing.Color.DimGray;
            this.laComprobacionLogin.Location = new System.Drawing.Point(256, 200);
            this.laComprobacionLogin.Name = "laComprobacionLogin";
            this.laComprobacionLogin.Size = new System.Drawing.Size(52, 21);
            this.laComprobacionLogin.TabIndex = 12;
            this.laComprobacionLogin.Text = "label3";
            // 
            // tbCorreoRecuperacion
            // 
            this.tbCorreoRecuperacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreoRecuperacion.Location = new System.Drawing.Point(3, 8);
            this.tbCorreoRecuperacion.Name = "tbCorreoRecuperacion";
            this.tbCorreoRecuperacion.Size = new System.Drawing.Size(248, 27);
            this.tbCorreoRecuperacion.TabIndex = 13;
            this.tbCorreoRecuperacion.Text = "Introduce dirección de correo";
            this.tbCorreoRecuperacion.Enter += new System.EventHandler(this.tbCorreoRecuperacion_Enter);
            this.tbCorreoRecuperacion.Leave += new System.EventHandler(this.tbCorreoRecuperacion_Leave);
            // 
            // btEnviarCorreo
            // 
            this.btEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviarCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviarCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEnviarCorreo.Location = new System.Drawing.Point(250, 8);
            this.btEnviarCorreo.Name = "btEnviarCorreo";
            this.btEnviarCorreo.Size = new System.Drawing.Size(113, 27);
            this.btEnviarCorreo.TabIndex = 14;
            this.btEnviarCorreo.Text = "Enviar Email";
            this.btEnviarCorreo.UseVisualStyleBackColor = true;
            this.btEnviarCorreo.Click += new System.EventHandler(this.btEnviarCorreo_Click);
            // 
            // pnRecuperarContraseña
            // 
            this.pnRecuperarContraseña.Controls.Add(this.tbCorreoRecuperacion);
            this.pnRecuperarContraseña.Controls.Add(this.btEnviarCorreo);
            this.pnRecuperarContraseña.Location = new System.Drawing.Point(352, 241);
            this.pnRecuperarContraseña.Name = "pnRecuperarContraseña";
            this.pnRecuperarContraseña.Size = new System.Drawing.Size(375, 43);
            this.pnRecuperarContraseña.TabIndex = 15;
            // 
            // laConfirmacionEnvioContraseña
            // 
            this.laConfirmacionEnvioContraseña.AutoSize = true;
            this.laConfirmacionEnvioContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laConfirmacionEnvioContraseña.ForeColor = System.Drawing.Color.Lime;
            this.laConfirmacionEnvioContraseña.Location = new System.Drawing.Point(358, 257);
            this.laConfirmacionEnvioContraseña.Name = "laConfirmacionEnvioContraseña";
            this.laConfirmacionEnvioContraseña.Size = new System.Drawing.Size(231, 21);
            this.laConfirmacionEnvioContraseña.TabIndex = 16;
            this.laConfirmacionEnvioContraseña.Text = "¡Correo enviado correctamente!";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(776, 390);
            this.Controls.Add(this.laConfirmacionEnvioContraseña);
            this.Controls.Add(this.pnRecuperarContraseña);
            this.Controls.Add(this.laComprobacionLogin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancelLogin);
            this.Controls.Add(this.btAcceptLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbUserLogin);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.Text = "FormLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.pnRecuperarContraseña.ResumeLayout(false);
            this.pnRecuperarContraseña.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAcceptLogin;
        private System.Windows.Forms.Button btCancelLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkRegistro;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laComprobacionLogin;
        private System.Windows.Forms.TextBox tbCorreoRecuperacion;
        private System.Windows.Forms.Button btEnviarCorreo;
        private System.Windows.Forms.Panel pnRecuperarContraseña;
        private System.Windows.Forms.Label laConfirmacionEnvioContraseña;
    }
}