using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Facturacion.Datos;

namespace Facturacion.Formularios
{
    public partial class frmFacturacion : Form
    {
        public string consulta, dataset, factura;
        public frmFacturacion(string sql)
        {
            consulta = sql;
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {

            this.rptFactu.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            dataset = "Dataset1";
            factura = "Facturacion.rptFactura.rdlc";
            DataSet ds = clsConexionSQL.QueryConsultaDataSet(consulta);

            ReportDataSource rd = new ReportDataSource(dataset, ds.Tables[0]);
            rptFactu.LocalReport.DataSources.Clear();
            rptFactu.LocalReport.DataSources.Add(rd);
            rptFactu.LocalReport.ReportEmbeddedResource = factura;
            rptFactu.LocalReport.Refresh();
            rptFactu.Refresh();
            rptFactu.RefreshReport();

        }
    }
}
