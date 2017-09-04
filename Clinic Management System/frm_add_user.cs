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
    public partial class frm_add_user : Form
    {
        DataTable dt;
        public frm_add_user()
        {
            //MessageBox.Show(Main_Form.curnt_user);
            InitializeComponent();
        }
        private bool validate()
        {
            if (txt_user_name.Text =="")
            {
                MessageBox.Show("يجب اختيار اسم المستخدم ");
                return false;
            }
            else if (txt_emp_id.Text == "")
            {
                MessageBox.Show("يجب اختيار الموظف");
                return false;
            }
            else if (txt_password.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور");
                return false;
            }
            else if (txt_repeat_password.Text == "")
            {
                MessageBox.Show("يجب تأكيد كلمة المرور");
                return false;
            }
            else if (txt_password.Text != txt_repeat_password.Text)
            {
                MessageBox.Show("كلمتا السر غير متطابقتان");
                return false;
            }
            
            return true;
        }
        private void btn_search_employee_Click(object sender, EventArgs e)
        {
            frm_employee frm = new frm_employee();
            frm.Name = "search";
            frm.btn_add.Visible = false;
            frm.btn_delete .Visible= false;
            frm.btn_edit.Visible = false;
            frm.btn_exit.Visible = true;
            frm.btn_accept.Visible = true;
            
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                this.txt_emp_id.Text = frm_employee.id;
                this.txt_emp_name.Text = frm_employee.name;
            }
        }
        cls_user user;
        Connection con = new Connection();
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                user = new cls_user();
                if (this.Name == "add_user")
                {
                    if (validate())
                    {
                        if (con.ExecuteQueries("insert into user values('" + txt_user_id.Text + "','" + txt_user_name.Text + "','" + txt_password.Text + "','" + txt_emp_id.Text + "','" + txt_emp_name.Text + "')" 
                            + ";insert into tb_priv(priv_screen_id,priv_user_id) select screen_id,'" + txt_user_id.Text + "' from tb_screen;"))
                        {
                            MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ts_btn_clear_Click(object sender, EventArgs e)
        {
            txt_emp_id.Text = "";
            txt_emp_name.Text = "";
            txt_password.Text = "";
            txt_user_name.Text = "";
            txt_repeat_password.Text = "";
        }

        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_repeat_password.UseSystemPasswordChar = false;
                cb_showpassword.Image = global::Clinic_Management_System.Properties.Resources.Hide_32x32;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_repeat_password.UseSystemPasswordChar = true;
                cb_showpassword.Image = global::Clinic_Management_System.Properties.Resources.Show_32x32;
            }
        }

        private void frm_add_user_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lb_curent_user.Text = Main_Form.curnt_emp;

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            //lb_curent_user.Text = Main_Form.curnt_user; 
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
           lb_curent_user.Text = Main_Form.curnt_emp; 
        }
       
    }
}
