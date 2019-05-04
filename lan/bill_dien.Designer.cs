namespace lan
{
    partial class bill_dien
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
            this.DO_ANDataSet = new lan.DO_ANDataSet();
            this.dienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dienTableAdapter = new lan.DO_ANDataSetTableAdapters.dienTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DO_ANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DO_ANDataSet
            // 
            this.DO_ANDataSet.DataSetName = "DO_ANDataSet";
            this.DO_ANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dienBindingSource
            // 
            this.dienBindingSource.DataMember = "dien";
            this.dienBindingSource.DataSource = this.DO_ANDataSet;
            // 
            // dienTableAdapter
            // 
            this.dienTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lan.Bill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // bill_dien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "bill_dien";
            this.Text = "bill_dien";
            this.Load += new System.EventHandler(this.bill_dien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DO_ANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dienBindingSource;
        private DO_ANDataSet DO_ANDataSet;
        private DO_ANDataSetTableAdapters.dienTableAdapter dienTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}