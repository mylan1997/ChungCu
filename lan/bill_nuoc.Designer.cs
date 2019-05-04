namespace lan
{
    partial class bill_nuoc
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
            this.nuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nuocTableAdapter = new lan.DO_ANDataSetTableAdapters.nuocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DO_ANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nuocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lan.2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(851, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // DO_ANDataSet
            // 
            this.DO_ANDataSet.DataSetName = "DO_ANDataSet";
            this.DO_ANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nuocBindingSource
            // 
            this.nuocBindingSource.DataMember = "nuoc";
            this.nuocBindingSource.DataSource = this.DO_ANDataSet;
            // 
            // nuocTableAdapter
            // 
            this.nuocTableAdapter.ClearBeforeFill = true;
            // 
            // bill_nuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "bill_nuoc";
            this.Text = "bill_nuoc";
            this.Load += new System.EventHandler(this.bill_nuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DO_ANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nuocBindingSource;
        private DO_ANDataSet DO_ANDataSet;
        private DO_ANDataSetTableAdapters.nuocTableAdapter nuocTableAdapter;
    }
}