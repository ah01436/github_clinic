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
    public partial class frm_rptExpensives : Form
    {
        DataTable dt;
        public frm_rptExpensives()
        {
            InitializeComponent();
        }

        private void frm_rptExpensives_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();

                query = @"select expenses.id,name,expense_date,price,notes from expenses,item_expense where  expenses.item_id=item_expense.id and expense_date>'" + dtp_from.Value.ToString("yyyy/MM/dd") + "' AND expense_date <='" + dtp_to.Value.ToString("yyyy/MM/dd") + "'";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("expenses", dt);
                reportViewer1.LocalReport.DataSources.Add(rtds);
                reportViewer1.RefreshReport();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                string query;
                DataTable dt = new DataTable();

                query = @"select expenses.id,name,expense_date,price,notes from expenses,item_expense where  expenses.item_id=item_expense.id;";
                dt.Clear();
                dt = (DataTable)conn.selectt(query);
                conn.CloseConnection();
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("expenses", dt);
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
