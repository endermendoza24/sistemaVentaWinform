
namespace Facturacion
{
    partial class frmReporte2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblFacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds = new Facturacion.Datos.Ds();
            this.rptFacturar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblFacTableAdapter = new Facturacion.Datos.DsTableAdapters.tblFacTableAdapter();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.btnFact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds)).BeginInit();
            this.SuspendLayout();
            // 
            // tblFacBindingSource
            // 
            this.tblFacBindingSource.DataMember = "tblFac";
            this.tblFacBindingSource.DataSource = this.Ds;
            // 
            // Ds
            // 
            this.Ds.DataSetName = "Ds";
            this.Ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptFacturar
            // 
            this.rptFacturar.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblFacBindingSource;
            this.rptFacturar.LocalReport.DataSources.Add(reportDataSource3);
            this.rptFacturar.LocalReport.ReportEmbeddedResource = "Facturacion.rptFact.rdlc";
            this.rptFacturar.Location = new System.Drawing.Point(0, 0);
            this.rptFacturar.Name = "rptFacturar";
            this.rptFacturar.ServerReport.BearerToken = null;
            this.rptFacturar.Size = new System.Drawing.Size(800, 450);
            this.rptFacturar.TabIndex = 0;
            // 
            // tblFacTableAdapter
            // 
            this.tblFacTableAdapter.ClearBeforeFill = true;
            // 
            // txtFact
            // 
            this.txtFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFact.Location = new System.Drawing.Point(627, 12);
            this.txtFact.MaxLength = 100;
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(89, 26);
            this.txtFact.TabIndex = 1;
            this.txtFact.TextChanged += new System.EventHandler(this.txtFact_TextChanged);
            this.txtFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFact_KeyPress);
            // 
            // btnFact
            // 
            this.btnFact.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFact.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFact.Location = new System.Drawing.Point(547, 1);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(74, 51);
            this.btnFact.TabIndex = 2;
            this.btnFact.Text = "Facturar";
            this.btnFact.UseVisualStyleBackColor = false;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // frmReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.rptFacturar);
            this.Name = "frmReporte2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporte2";
            this.Load += new System.EventHandler(this.frmReporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFacturar;
        private System.Windows.Forms.BindingSource tblFacBindingSource;
        private Datos.Ds Ds;
        private Datos.DsTableAdapters.tblFacTableAdapter tblFacTableAdapter;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.Button btnFact;
    }
}