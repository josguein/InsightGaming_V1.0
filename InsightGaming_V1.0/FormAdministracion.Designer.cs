namespace InsightGaming_V1._0
{
    partial class FormAdministracion
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
            this.bd_gaminginsightDataSet1 = new InsightGaming_V1._0.bd_gaminginsightDataSet1();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new InsightGaming_V1._0.bd_gaminginsightDataSet1TableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new InsightGaming_V1._0.bd_gaminginsightDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gaminginsightDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bd_gaminginsightDataSet1
            // 
            this.bd_gaminginsightDataSet1.DataSetName = "bd_gaminginsightDataSet1";
            this.bd_gaminginsightDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.bd_gaminginsightDataSet1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Detalle_CompraTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.ticketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InsightGaming_V1._0.bd_gaminginsightDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.Load += new System.EventHandler(this.FormAdministracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_gaminginsightDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bd_gaminginsightDataSet1 bd_gaminginsightDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private bd_gaminginsightDataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private bd_gaminginsightDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}