
namespace Facturacion.Formularios
{
    partial class frmFacturacion
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
            this.rptFactu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptFactu
            // 
            this.rptFactu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptFactu.LocalReport.ReportEmbeddedResource = "Facturacion.rptFactura.rdlc";
            this.rptFactu.Location = new System.Drawing.Point(0, 0);
            this.rptFactu.Name = "rptFactu";
            this.rptFactu.ServerReport.BearerToken = null;
            this.rptFactu.Size = new System.Drawing.Size(435, 450);
            this.rptFactu.TabIndex = 0;
            this.rptFactu.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.rptFactu);
            this.Name = "frmFacturacion";
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFactu;
    }
}