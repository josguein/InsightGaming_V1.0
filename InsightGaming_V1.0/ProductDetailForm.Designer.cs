namespace InsightGaming_V1._0
{
    partial class ProductDetailForm
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
            this.laTitulo = new System.Windows.Forms.Label();
            this.laRating = new System.Windows.Forms.Label();
            this.laMetacritic = new System.Windows.Forms.Label();
            this.btComprar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.BackColor = System.Drawing.Color.Transparent;
            this.laTitulo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.laTitulo.Location = new System.Drawing.Point(304, 9);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(0, 50);
            this.laTitulo.TabIndex = 2;
            // 
            // laRating
            // 
            this.laRating.AutoSize = true;
            this.laRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRating.ForeColor = System.Drawing.Color.DimGray;
            this.laRating.Location = new System.Drawing.Point(59, 191);
            this.laRating.Name = "laRating";
            this.laRating.Size = new System.Drawing.Size(43, 17);
            this.laRating.TabIndex = 3;
            this.laRating.Text = "label1";
            this.laRating.Click += new System.EventHandler(this.laRating_Click);
            // 
            // laMetacritic
            // 
            this.laMetacritic.AutoSize = true;
            this.laMetacritic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMetacritic.ForeColor = System.Drawing.Color.DimGray;
            this.laMetacritic.Location = new System.Drawing.Point(641, 195);
            this.laMetacritic.Name = "laMetacritic";
            this.laMetacritic.Size = new System.Drawing.Size(43, 17);
            this.laMetacritic.TabIndex = 4;
            this.laMetacritic.Text = "label2";
            this.laMetacritic.Click += new System.EventHandler(this.laMetacritic_Click);
            // 
            // btComprar
            // 
            this.btComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComprar.Location = new System.Drawing.Point(129, 336);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(476, 62);
            this.btComprar.TabIndex = 7;
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InsightGaming_V1._0.Properties.Resources.rating;
            this.pictureBox2.Location = new System.Drawing.Point(31, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InsightGaming_V1._0.Properties.Resources.metacritic;
            this.pictureBox1.Location = new System.Drawing.Point(615, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbFondo
            // 
            this.pbFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(800, 450);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 1;
            this.pbFondo.TabStop = false;
            this.pbFondo.Click += new System.EventHandler(this.pbFondo_Click);
            this.pbFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFondo_MouseDown);
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.laMetacritic);
            this.Controls.Add(this.laRating);
            this.Controls.Add(this.laTitulo);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Label laTitulo;
        private System.Windows.Forms.Label laRating;
        private System.Windows.Forms.Label laMetacritic;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}