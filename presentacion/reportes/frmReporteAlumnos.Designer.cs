namespace pjGestionEscuela.presentacion.reportes
{
    partial class frmReporteAlumnos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet = new pjGestionEscuela.presentacion.reportes.DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LISTAR_ALUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPLISTARALUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LISTAR_ALUMNOSTableAdapter = new pjGestionEscuela.presentacion.reportes.DataSetTableAdapters.SP_LISTAR_ALUMNOSTableAdapter();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTAR_ALUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPLISTARALUMNOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pjGestionEscuela.presentacion.reportes.ReporteAlumnos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1014, 709);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // dataSetBindingSource1
            // 
            this.dataSetBindingSource1.DataSource = this.dataSet;
            this.dataSetBindingSource1.Position = 0;
            // 
            // SP_LISTAR_ALUMNOSBindingSource
            // 
            this.SP_LISTAR_ALUMNOSBindingSource.DataMember = "SP_LISTAR_ALUMNOS";
            this.SP_LISTAR_ALUMNOSBindingSource.DataSource = this.dataSet;
            // 
            // sPLISTARALUMNOSBindingSource
            // 
            this.sPLISTARALUMNOSBindingSource.DataMember = "SP_LISTAR_ALUMNOS";
            this.sPLISTARALUMNOSBindingSource.DataSource = this.dataSet;
            // 
            // sP_LISTAR_ALUMNOSTableAdapter
            // 
            this.sP_LISTAR_ALUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(23, 37);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 22);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.Visible = false;
            // 
            // frmReporteAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 709);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteAlumnos";
            this.Text = "Reporte Alumnos";
            this.Load += new System.EventHandler(this.frmReporteAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTAR_ALUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPLISTARALUMNOSBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.BindingSource dataSetBindingSource1;
        private System.Windows.Forms.BindingSource SP_LISTAR_ALUMNOSBindingSource;
        private DataSetTableAdapters.SP_LISTAR_ALUMNOSTableAdapter sP_LISTAR_ALUMNOSTableAdapter;
        internal System.Windows.Forms.TextBox txtFiltrar;
    }
}