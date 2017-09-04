using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Clinic_Management_System
{
    public partial class frmServerSetting : Form
    {
        public frmServerSetting()
        {
            InitializeComponent();
        }
        private void frmServerSetting_Load(object sender, EventArgs e)
        {
            var p = Properties.Settings.Default;
            txtServerName.Text = p.Server;
            txt_port.Text = p.port;
            txtUser.Text = p.uid;
            txtPass.Text = p.password;
            txt_database.Text = p.database;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Connection con = new Connection(txtServerName.Text, txt_port.Text, txt_database.Text, txtUser.Text, txtPass.Text);
            if (con.OpenConnection())
            {
                if (cb_remember.Checked == true)
                {
                    var p = Properties.Settings.Default;
                    Properties.Settings.Default.Server = txtServerName.Text;
                    Properties.Settings.Default.port = txt_port.Text;
                    Properties.Settings.Default.uid = txtUser.Text;
                    Properties.Settings.Default.password = txtPass.Text;
                    Properties.Settings.Default.database = txt_database.Text; 
                    Properties.Settings.Default.Save();
                }
                
                MessageBox.Show("تم حفظ الاعداد بنجاح "); 
                this.Close();

            }
            else
            {
                MessageBox.Show("ادخل بيانات السيرفر الصحيحة");
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_test_connection_Click(object sender, EventArgs e)
        {
            Connection con = new Connection(txtServerName.Text, txt_port.Text, txt_database.Text, txtUser.Text, txtPass.Text);
            if (con.OpenConnection())
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("ادخل بيانات السيرفر الصحيحة");
            }
        }

    }
}
