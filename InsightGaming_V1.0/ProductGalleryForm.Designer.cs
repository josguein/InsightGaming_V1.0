namespace InsightGaming_V1._0
{
    partial class ProductGalleryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPrecios = new System.Windows.Forms.GroupBox();
            this.btRecargarStock = new System.Windows.Forms.Button();
            this.btBuscarPorNombre = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.rbListaPreciomenos10 = new System.Windows.Forms.RadioButton();
            this.rbListaPreciomenos20 = new System.Windows.Forms.RadioButton();
            this.rbListaPrecio2040 = new System.Windows.Forms.RadioButton();
            this.rbListaPrecio4060 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbListaIndie = new System.Windows.Forms.RadioButton();
            this.rbListaEstrategia = new System.Windows.Forms.RadioButton();
            this.rbListaSimulacion = new System.Windows.Forms.RadioButton();
            this.rbListaAventuras = new System.Windows.Forms.RadioButton();
            this.rbListaDeportes = new System.Windows.Forms.RadioButton();
            this.rbListaShooter = new System.Windows.Forms.RadioButton();
            this.rbListaRPG = new System.Windows.Forms.RadioButton();
            this.rbListaAccion = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbPrecios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPrecios);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 450);
            this.panel1.TabIndex = 0;
            // 
            // gbPrecios
            // 
            this.gbPrecios.Controls.Add(this.btRecargarStock);
            this.gbPrecios.Controls.Add(this.btBuscarPorNombre);
            this.gbPrecios.Controls.Add(this.tbBusqueda);
            this.gbPrecios.Controls.Add(this.rbListaPreciomenos10);
            this.gbPrecios.Controls.Add(this.rbListaPreciomenos20);
            this.gbPrecios.Controls.Add(this.rbListaPrecio2040);
            this.gbPrecios.Controls.Add(this.rbListaPrecio4060);
            this.gbPrecios.Location = new System.Drawing.Point(3, 12);
            this.gbPrecios.Name = "gbPrecios";
            this.gbPrecios.Size = new System.Drawing.Size(149, 203);
            this.gbPrecios.TabIndex = 1;
            this.gbPrecios.TabStop = false;
            this.gbPrecios.Text = "Clasificar por precio";
            // 
            // btRecargarStock
            // 
            this.btRecargarStock.Location = new System.Drawing.Point(31, 119);
            this.btRecargarStock.Name = "btRecargarStock";
            this.btRecargarStock.Size = new System.Drawing.Size(75, 23);
            this.btRecargarStock.TabIndex = 6;
            this.btRecargarStock.Text = "Recargar Stock";
            this.btRecargarStock.UseVisualStyleBackColor = true;
            this.btRecargarStock.Visible = false;
            this.btRecargarStock.Click += new System.EventHandler(this.btRecargarStock_Click);
            // 
            // btBuscarPorNombre
            // 
            this.btBuscarPorNombre.Location = new System.Drawing.Point(31, 174);
            this.btBuscarPorNombre.Name = "btBuscarPorNombre";
            this.btBuscarPorNombre.Size = new System.Drawing.Size(75, 23);
            this.btBuscarPorNombre.TabIndex = 5;
            this.btBuscarPorNombre.Text = "Buscar";
            this.btBuscarPorNombre.UseVisualStyleBackColor = true;
            this.btBuscarPorNombre.Click += new System.EventHandler(this.btBuscarPorNombre_Click);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(15, 148);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(108, 20);
            this.tbBusqueda.TabIndex = 4;
            // 
            // rbListaPreciomenos10
            // 
            this.rbListaPreciomenos10.AutoSize = true;
            this.rbListaPreciomenos10.Location = new System.Drawing.Point(15, 97);
            this.rbListaPreciomenos10.Name = "rbListaPreciomenos10";
            this.rbListaPreciomenos10.Size = new System.Drawing.Size(96, 17);
            this.rbListaPreciomenos10.TabIndex = 3;
            this.rbListaPreciomenos10.TabStop = true;
            this.rbListaPreciomenos10.Text = "Menos de 10 €";
            this.rbListaPreciomenos10.UseVisualStyleBackColor = true;
            this.rbListaPreciomenos10.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaPreciomenos20
            // 
            this.rbListaPreciomenos20.AutoSize = true;
            this.rbListaPreciomenos20.Location = new System.Drawing.Point(14, 74);
            this.rbListaPreciomenos20.Name = "rbListaPreciomenos20";
            this.rbListaPreciomenos20.Size = new System.Drawing.Size(96, 17);
            this.rbListaPreciomenos20.TabIndex = 2;
            this.rbListaPreciomenos20.TabStop = true;
            this.rbListaPreciomenos20.Text = "Menos de 20 €";
            this.rbListaPreciomenos20.UseVisualStyleBackColor = true;
            this.rbListaPreciomenos20.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaPrecio2040
            // 
            this.rbListaPrecio2040.AutoSize = true;
            this.rbListaPrecio2040.Location = new System.Drawing.Point(15, 51);
            this.rbListaPrecio2040.Name = "rbListaPrecio2040";
            this.rbListaPrecio2040.Size = new System.Drawing.Size(97, 17);
            this.rbListaPrecio2040.TabIndex = 1;
            this.rbListaPrecio2040.TabStop = true;
            this.rbListaPrecio2040.Text = "Entre 20 y 40 €";
            this.rbListaPrecio2040.UseVisualStyleBackColor = true;
            this.rbListaPrecio2040.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaPrecio4060
            // 
            this.rbListaPrecio4060.AutoSize = true;
            this.rbListaPrecio4060.Location = new System.Drawing.Point(14, 28);
            this.rbListaPrecio4060.Name = "rbListaPrecio4060";
            this.rbListaPrecio4060.Size = new System.Drawing.Size(97, 17);
            this.rbListaPrecio4060.TabIndex = 0;
            this.rbListaPrecio4060.TabStop = true;
            this.rbListaPrecio4060.Text = "Entre 40 y 60 €";
            this.rbListaPrecio4060.UseVisualStyleBackColor = true;
            this.rbListaPrecio4060.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbListaIndie);
            this.groupBox1.Controls.Add(this.rbListaEstrategia);
            this.groupBox1.Controls.Add(this.rbListaSimulacion);
            this.groupBox1.Controls.Add(this.rbListaAventuras);
            this.groupBox1.Controls.Add(this.rbListaDeportes);
            this.groupBox1.Controls.Add(this.rbListaShooter);
            this.groupBox1.Controls.Add(this.rbListaRPG);
            this.groupBox1.Controls.Add(this.rbListaAccion);
            this.groupBox1.Location = new System.Drawing.Point(3, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Genero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbListaIndie
            // 
            this.rbListaIndie.AutoSize = true;
            this.rbListaIndie.Location = new System.Drawing.Point(32, 185);
            this.rbListaIndie.Name = "rbListaIndie";
            this.rbListaIndie.Size = new System.Drawing.Size(48, 17);
            this.rbListaIndie.TabIndex = 15;
            this.rbListaIndie.TabStop = true;
            this.rbListaIndie.Text = "Indie";
            this.rbListaIndie.UseVisualStyleBackColor = true;
            this.rbListaIndie.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaEstrategia
            // 
            this.rbListaEstrategia.AutoSize = true;
            this.rbListaEstrategia.Location = new System.Drawing.Point(31, 162);
            this.rbListaEstrategia.Name = "rbListaEstrategia";
            this.rbListaEstrategia.Size = new System.Drawing.Size(72, 17);
            this.rbListaEstrategia.TabIndex = 14;
            this.rbListaEstrategia.TabStop = true;
            this.rbListaEstrategia.Text = "Estrategia";
            this.rbListaEstrategia.UseVisualStyleBackColor = true;
            this.rbListaEstrategia.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaSimulacion
            // 
            this.rbListaSimulacion.AutoSize = true;
            this.rbListaSimulacion.Location = new System.Drawing.Point(32, 139);
            this.rbListaSimulacion.Name = "rbListaSimulacion";
            this.rbListaSimulacion.Size = new System.Drawing.Size(76, 17);
            this.rbListaSimulacion.TabIndex = 13;
            this.rbListaSimulacion.TabStop = true;
            this.rbListaSimulacion.Text = "Simulacion";
            this.rbListaSimulacion.UseVisualStyleBackColor = true;
            this.rbListaSimulacion.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaAventuras
            // 
            this.rbListaAventuras.AutoSize = true;
            this.rbListaAventuras.Location = new System.Drawing.Point(32, 116);
            this.rbListaAventuras.Name = "rbListaAventuras";
            this.rbListaAventuras.Size = new System.Drawing.Size(73, 17);
            this.rbListaAventuras.TabIndex = 12;
            this.rbListaAventuras.TabStop = true;
            this.rbListaAventuras.Text = "Aventuras";
            this.rbListaAventuras.UseVisualStyleBackColor = true;
            this.rbListaAventuras.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaDeportes
            // 
            this.rbListaDeportes.AutoSize = true;
            this.rbListaDeportes.Location = new System.Drawing.Point(32, 93);
            this.rbListaDeportes.Name = "rbListaDeportes";
            this.rbListaDeportes.Size = new System.Drawing.Size(68, 17);
            this.rbListaDeportes.TabIndex = 11;
            this.rbListaDeportes.TabStop = true;
            this.rbListaDeportes.Text = "Deportes";
            this.rbListaDeportes.UseVisualStyleBackColor = true;
            this.rbListaDeportes.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaShooter
            // 
            this.rbListaShooter.AutoSize = true;
            this.rbListaShooter.Location = new System.Drawing.Point(31, 70);
            this.rbListaShooter.Name = "rbListaShooter";
            this.rbListaShooter.Size = new System.Drawing.Size(62, 17);
            this.rbListaShooter.TabIndex = 10;
            this.rbListaShooter.TabStop = true;
            this.rbListaShooter.Text = "Shooter";
            this.rbListaShooter.UseVisualStyleBackColor = true;
            this.rbListaShooter.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaRPG
            // 
            this.rbListaRPG.AutoSize = true;
            this.rbListaRPG.Location = new System.Drawing.Point(32, 47);
            this.rbListaRPG.Name = "rbListaRPG";
            this.rbListaRPG.Size = new System.Drawing.Size(48, 17);
            this.rbListaRPG.TabIndex = 9;
            this.rbListaRPG.TabStop = true;
            this.rbListaRPG.Text = "RPG";
            this.rbListaRPG.UseVisualStyleBackColor = true;
            this.rbListaRPG.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // rbListaAccion
            // 
            this.rbListaAccion.AutoSize = true;
            this.rbListaAccion.Location = new System.Drawing.Point(32, 24);
            this.rbListaAccion.Name = "rbListaAccion";
            this.rbListaAccion.Size = new System.Drawing.Size(58, 17);
            this.rbListaAccion.TabIndex = 8;
            this.rbListaAccion.TabStop = true;
            this.rbListaAccion.Text = "Accion";
            this.rbListaAccion.UseVisualStyleBackColor = true;
            this.rbListaAccion.CheckedChanged += new System.EventHandler(this.rbListaAccion_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(941, 0);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(32, 26);
            this.btCerrar.TabIndex = 16;
            this.btCerrar.Text = "X";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // ProductGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductGalleryForm";
            this.Opacity = 0.9D;
            this.Text = "ProductGalleryForm";
            this.Activated += new System.EventHandler(this.ProductGalleryForm_Activated);
            this.Load += new System.EventHandler(this.ProductGalleryForm_Load);
            this.panel1.ResumeLayout(false);
            this.gbPrecios.ResumeLayout(false);
            this.gbPrecios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbListaIndie;
        private System.Windows.Forms.RadioButton rbListaEstrategia;
        private System.Windows.Forms.RadioButton rbListaSimulacion;
        private System.Windows.Forms.RadioButton rbListaAventuras;
        private System.Windows.Forms.RadioButton rbListaDeportes;
        private System.Windows.Forms.RadioButton rbListaShooter;
        private System.Windows.Forms.RadioButton rbListaRPG;
        private System.Windows.Forms.RadioButton rbListaAccion;
        private System.Windows.Forms.GroupBox gbPrecios;
        private System.Windows.Forms.RadioButton rbListaPreciomenos10;
        private System.Windows.Forms.RadioButton rbListaPreciomenos20;
        private System.Windows.Forms.RadioButton rbListaPrecio2040;
        private System.Windows.Forms.RadioButton rbListaPrecio4060;
        private System.Windows.Forms.Button btBuscarPorNombre;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button btRecargarStock;
        private System.Windows.Forms.Button btCerrar;
    }
}