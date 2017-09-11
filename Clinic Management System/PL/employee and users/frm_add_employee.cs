using System;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class add_employee : Form
    {
        cls_validate cls = new cls_validate();
        ToolTip tt;
        int VisibleTime = 1000;
        public add_employee()
        {
            InitializeComponent();
        }
        private string id;
        private string name;
        private string gender="انثى";
        private string birth_date;
        private string status="متزوجة";
        private string reg_date;
        private string address;
        private string phone1;
        private string email;
        private string staff_type="دكتور";
        private string nat_id;
        private string position="";
        public bool vaildate_text()
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم الموظف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tabControl_patient_info.SelectedTab = this.tabControl_patient_info.TabPages["tab_basic_info"];
                    txt_name.Focus();
                    return false;
                    
                }
                if (dtp_birth_date.Value.Date.ToShortDateString() == dtb_reg_date.Value.Date.ToShortDateString() ||
                    dtp_birth_date.Value.Date> dtb_reg_date.Value.Date)
                {
                    MessageBox.Show("يجب تسجيل تاريخ الميلاد بطريقة صحيحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tabControl_patient_info.SelectedTab = this.tabControl_patient_info.TabPages["tab_basic_info"];
                    dtp_birth_date.Focus();
                    return false;
                }
                if (txt_phone1.Text == "")
                {
                    MessageBox.Show("يجب ادخال رقم الهاتف  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tabControl_patient_info.SelectedTab = this.tabControl_patient_info.TabPages["tab_contact_info"];
                    txt_phone1.Focus();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (vaildate_text())
                {
                    id = txt_id.Text;
                    name = txt_name.Text;
                    birth_date = dtp_birth_date.Value.ToString("yyyy-MM-dd");
                    reg_date = dtb_reg_date.Value.ToString("yyyy-MM-dd");                 
                    address = txt_address.Text;
                    phone1 = txt_phone1.Text;
                    email = txt_email.Text;
                    cls_employee p = new cls_employee();
                    Connection con = new Connection();
                    if (this.Name == "add_employee")
                    {
                        if (con.ExecuteQueries(@"insert into staff values ('"+id+"','"+name+"','"+gender+"','"
                            +birth_date+"','"+reg_date+"','"+status+"','"+address+"','"+email+"','"+phone1+"','"
                            +position+"','"+txt_nat_id.Text+"')"))
                        {
                            MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (this.Name == "update_employee")
                    {
                        if (con.ExecuteQueries(@"update staff set staff_name='"+name+"',staff_gender='"+gender+"',staff_birth_date='"+birth_date+
                            "',staff_date_of_employee='"+reg_date+"',staff_status='"+status+"',staff_address='"+address+"',staff_email='"+email+
                            "',staff_contact_no = '" + phone1 + "',staff_position='" + position + "',staff_nat_id='" + txt_nat_id.Text + "' where staff_id = '"+id+"'"))
                        {
                            MessageBox.Show("تمت التعديل بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ts_btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Clear();
            txt_email.Clear();
            txt_name.Clear();
            txt_phone1.Clear();
            dtb_reg_date.ResetText();
            dtp_birth_date.ResetText();
            rdb_mairried.Checked = true;
            rdb_female.Checked = true;
        }
        private void rdb_female_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_female.Checked)
            {
                gender = "انثى";
            }
            else
            {
                gender = "ذكر";
            }
            check_status();
        }
        public void check_status()
        {
            if (rdb_single.Checked)
            {
                if (rdb_female.Checked)
                {
                    status = "عزباء";
                }
                else
                {
                    status = "اعزب";
                }
            }
            else if (rdb_mairried.Checked)
            {
                if (rdb_female.Checked)
                {
                    status = "متزوجه";
                }
                else
                {
                    status = "متزوج";
                }
            }
            else if (rdb_motalk.Checked)
            {
                if (rdb_female.Checked)
                {
                    status = "مطلقة";
                }
                else
                {
                    status = "مطلق";
                }
            }
            else if(rdb_armal.Checked)
            {
                if (rdb_female.Checked)
                {
                    status = "أرملة";
                }
                else
                {
                    status = "أرمل";
                }
            }
        }
        private void rdb_single_CheckedChanged(object sender, EventArgs e)
        {
            check_status();
        }
        private void txt_phone1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdp_doctor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_doc.Checked)
            { 
            position="دكتور";
            }
            else 
            {
                position = "ممرض";
            }
        }

        

        private void txt_nat_id_Leave(object sender, EventArgs e)
        {
            if (!cls_validate.IsValidNationalID(txt_nat_id.Text))
            {
                MessageBox.Show("من فضلك ادخل الرقم القومى بشكل صحيح");
            }

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // btnSearch.Enabled = false;
                  //in milliseconds
                 tt = new ToolTip();
                tt.Show("اسم الموظف " + " يجب ان يكون حروف فقط ", txt_name, 0, 0, VisibleTime);
                e.Handled = true;
            }
        }

        private void txt_nat_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                tt = new ToolTip();
                tt.Show("الرقم القومى " + " يجب ان يكون ارقام ", txt_nat_id, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }
        }

        private void txt_phone1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                //   ts_btn_save.Enabled = false;
                //in milliseconds
                 tt = new ToolTip();
                tt.Show("رقم الهاتف " + " يجب ان يكون ارقام ", txt_phone1, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
            }   
        }
       
        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text != "")
            {
                if (!cls.IsValidEmail(txt_email.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا البريد الالكترونى الذى ادخلته غير صحيح", txt_email, 0, 0, VisibleTime);

                    txt_email.Focus();

                }
            }
        }

        private void txt_phone1_Leave(object sender, EventArgs e)
        {
            if (txt_phone1.Text != "")
            {
                if (!cls.IsvalidPhone(txt_phone1.Text))
                {
                    tt = new ToolTip();
                    tt.Show("عفوا رقم الهاتف الذى ادخلته غير صحيح", txt_phone1, 0, 0, VisibleTime);

                    txt_phone1.Focus();
                }
            }
        }

       
    }
}
