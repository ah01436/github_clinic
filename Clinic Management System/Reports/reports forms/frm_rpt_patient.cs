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
    public partial class frm_rpt_patient : Form
    {
        public frm_rpt_patient()
        {
            InitializeComponent();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();
                query = @"select patient_id,patient_name,patient_gender,patient_register_date,patient_address,patient_contact_no from patient;";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("patient", dt);
                reportViewer1.LocalReport.DataSources.Add(rtds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_rpt_patient_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {
                Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();
                query = @"select patient_id,patient_name,patient_gender,patient_register_date,patient_address,patient_contact_no from patient where patient_register_date >='" + dtp_from.Value.ToString("yyyy/MM/dd") + "' AND patient_register_date<='" + dtp_to.Value.ToString("yyyy/MM/dd") + "';";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("patient", dt);
                reportViewer1.LocalReport.DataSources.Add(rtds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
