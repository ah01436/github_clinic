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
    public partial class frm_expenses_item : Form
    {
        public frm_expenses_item()
        {
            InitializeComponent();
        }

        private void frm_expenses_item_Load(object sender, EventArgs e)
        {
            try{
             Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();
                query = @"select * from item_expense;";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("expenses_item", dt);
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
