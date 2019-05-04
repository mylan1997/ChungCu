namespace lan
{
    partial class hoa_don
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
            this.DO_ANDataSet = new lan.DO_ANDataSet();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonTableAdapter = new lan.DO_ANDataSetTableAdapters.hoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DO_ANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lan.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(848, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // DO_ANDataSet
            // 
            this.DO_ANDataSet.DataSetName = "DO_ANDataSet";
            this.DO_ANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.DO_ANDataSet;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // hoa_don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hoa_don";
            this.Text = "hoa_don";
            this.Load += new System.EventHandler(this.hoa_don_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DO_ANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private DO_ANDataSet DO_ANDataSet;
        private DO_ANDataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter;
    }
}