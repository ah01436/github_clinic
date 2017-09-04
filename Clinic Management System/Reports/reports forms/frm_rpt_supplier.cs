using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_rpt_supplier : Form
    {
        public frm_rpt_supplier()
        {
            InitializeComponent();
        }

        private void frm_rpt_supplier_Load(object sender, EventArgs e)
        {

            try
            {
                Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();
                query = @"select supplier_id,supplier_name,supplier_contact_no,supplier_contact_no2,supplier_email,supplier_address from supplier;";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("Ds", dt);
                reportViewer1.LocalReport.DataSources.Add(rtds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
