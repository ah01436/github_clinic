using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Log_in : Form
    {
        DataTable dt = new DataTable();
        DialogResult dr = new DialogResult();
        public Log_in()
        {
            InitializeComponent();
            //------------------ Mohamed Moafa Code For Execute Style ----------------
          //  skinEngine2.SkinFile = "Skins\\" + Properties.Settings.Default.style;
            ////------------------------------------------------------------------------
            //Properties.Settings.Default.formclose = 1;
            ////------------------ Mohamed Moafa Code For Fill Combobox with names of styles  ----------------
            //try
            //{
            //    if (Directory.Exists("Skins"))
            //        foreach (string file in Directory.GetFiles("Skins"))
            //           cmbStyle.Items.Add(Path.GetFileName(file));
            //    cmbStyle.Text = Properties.Settings.Default.style;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //-----------------------------------------------------------------------------------------------
        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                cb_showpassword.Image = global::Clinic_Management_System.Properties.Resources.Hide_32x32;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                cb_showpassword.Image = global::Clinic_Management_System.Properties.Resources.Show_32x32;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            dr = DialogResult.OK;
            if (Properties.Settings.Default.formclose == 1)
            {
                dr = MessageBox.Show("هل تريد الخروج من البرنامج ", "تنبيه ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.formclose += 1;
                Application.Exit();
            }
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------ Mohamed Moafa Code For Change styles  ----------------
            try
            {
                Properties.Settings.Default.style = cmbStyle.Text;
                Properties.Settings.Default.Save();
            //    skinEngine2.SkinFile = "Skins\\" + cmbStyle.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //-----------------------------------------------------------------------------------------------
        
        }
        public string curnet_user;
        private void btn_login_Click(object sender, EventArgs e)
        {
                Connection con = new Connection();
                dt = con.selectt("select * from user where userName='"+txt_username.Text+"'");
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("اسم المستخدم خطأ رجاء ادخال الاسم الصحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                if (dt.Rows[0][2].ToString() == txt_password.Text)
                {
                    string emp = "";
                    emp = (con.selectt("select staff.staff_name from staff where staff_id='" + dt.Rows[0][3].ToString() + "';")).Rows[0][0].ToString();
                    curnet_user = dt.Rows[0][0].ToString();
                    Main_Form frm = new Main_Form(curnet_user, emp);
                    frm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("كلمةالمرور خطأ رجاء ادخال كلمة المرور الصحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        
        private void Log_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            dr=DialogResult.OK;
            if (Properties.Settings.Default.formclose == 1)
            {
                dr = MessageBox.Show("هل تريد الخروج من البرنامج ", "تنبيه ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            } 
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.formclose += 1;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                Properties.Settings.Default.formclose = 1;
            }
        }
    }
}
