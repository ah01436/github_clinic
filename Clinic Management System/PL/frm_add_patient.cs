using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Clinic_Management_System
{
    public partial class frm_add_patient : Form
    {
        cls_validate cls = new cls_validate();
        ToolTip tt;
        int VisibleTime = 1000;
        Connection con = new Connection();
        DataTable dt;
        string transformer="";
        private string id;
        private string name;
        private string gender="انثى";
        private string birth_date;
        private string status="متزوجة";
        private string reg_date;
        private string address;
        private string phone1;
        private string email;
        public frm_add_patient()
        {
            InitializeComponent();
        }
        public bool vaildate_text()
        {
            try
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يجب ادخال اسم المريض ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Patient p = new Patient();
                    if (this.Name == "add_patient")
                    {
                        if (con.ExecuteQueries(@"insert into patient values('"+id+"','"+name+"','"+gender+"','"+birth_date
                            +"','"+reg_date+"','"+status+"','"+address+"','"+email+"','"+phone1+"',"+transformer+")"))
                        {
                            MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (this.Name == "update_patient")
                    {
                        if (con.ExecuteQueries("update patient set patient_name='"+name+"',patient_gender='"+gender+"',patient_birth_date='"
                            +birth_date+"',patient_register_date='"+reg_date+"',patient_status='"+status+"',patient_address='"+address
                            +"',patient_email='"+email+"',patient_contact_no='"+phone1+"',transformers_id="+transformer+" where patient_id='"+id+"'"))
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
       
        private void frm_add_patient_Load(object sender, EventArgs e)
        {

            if (this.Name == "add_patient")
            {
                dt = new DataTable();
                dt = con.selectt("select * from transformers;");
                cmb_transformers.DataSource = dt;
                cmb_transformers.ValueMember = "id";
                cmb_transformers.DisplayMember = "name";
                transformer = cmb_transformers.SelectedValue.ToString();
            }
            else
            {
                transformer = cmb_transformers.SelectedValue.ToString();
            }
        } 

        private void add_item_Click(object sender, EventArgs e)
        {
            frm_transformers frm = new frm_transformers();
            frm.ShowDialog();
            dt = new DataTable();
            dt = con.selectt("select * from transformers;");
            cmb_transformers.DataSource = dt;
            //frm_add_patient_Load(sender, e);
        }

        private void cmb_transformers_SelectedIndexChanged(object sender, EventArgs e)
        {
            transformer = cmb_transformers.SelectedValue.ToString();
            //MessageBox.Show(transformer);
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // btnSearch.Enabled = false;

                tt = new ToolTip();
                tt.Show("اسم المريض " + " يجب ان يكون حروف فقط ", txt_name, 0, 0, VisibleTime);
                //   MessageBox.Show("كود المريض يجب ان يكون ارقام فقط , رجاء لا تكتب حروف ");
                e.Handled = true;
                txt_name.Focus();
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
    }
}
