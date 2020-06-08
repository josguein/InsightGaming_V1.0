namespace InsightGaming_V1._0
{
    partial class FormProducts
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
            this.btRecargarStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGaleriaProductos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRecargarStock
            // 
            this.btRecargarStock.Location = new System.Drawing.Point(34, 147);
            this.btRecargarStock.Name = "btRecargarStock";
            this.btRecargarStock.Size = new System.Drawing.Size(298, 21);
            this.btRecargarStock.TabIndex = 0;
            this.btRecargarStock.Text = "Rellena o Recarga Stock";
            this.btRecargarStock.UseVisualStyleBackColor = true;
            this.btRecargarStock.Click += new System.EventHandler(this.btRecargarStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.btRecargarStock);
            this.panel1.Controls.Add(this.btGaleriaProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 649);
            this.panel1.TabIndex = 1;
            // 
            // btGaleriaProductos
            // 
            this.btGaleriaProductos.Location = new System.Drawing.Point(34, 103);
            this.btGaleriaProductos.Name = "btGaleriaProductos";
            this.btGaleriaProductos.Size = new System.Drawing.Size(298, 23);
            this.btGaleriaProductos.TabIndex = 2;
            this.btGaleriaProductos.Text = "Galeria de Productos";
            this.btGaleriaProductos.UseVisualStyleBackColor = true;
            this.btGaleriaProductos.Click += new System.EventHandler(this.btGaleriaProductos_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 649);
            this.Controls.Add(this.panel1);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRecargarStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGaleriaProductos;
    }
}