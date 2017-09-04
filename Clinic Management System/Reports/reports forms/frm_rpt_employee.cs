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
    public partial class frm_rpt_employee : Form
    {
        public frm_rpt_employee()
        {
            InitializeComponent();
        }

        private void frm_rpt_employee_Load(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();
                query = @"SELECT staff_id,staff_name,staff_gender,staff_date_of_employee,staff_address,staff_email,staff_contact_no from staff;";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("employee", dt);
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
