using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_employee : Form
    {
        public static string id;
        public static string name;
        public frm_employee()
        {
            InitializeComponent();
            loadPriv();
        }

        cls_employee emp;
        string emp_id;
        DataTable dt;
        DataView dv;
        // increase the genrate the id of new cls_employee
        public string increasekey(string id)
        {
            string new_id = "E_";
            new_id += (Convert.ToInt64(id.Substring(2, id.Length - 2)) + 1).ToString();
            return new_id;
        }
        private void frm_employee_Load(object sender, EventArgs e)
        {
            emp = new cls_employee();
            dt = new DataTable();
            //================================================================
            //لما اخلى الفورمة للبحث فقط 
            if (this.Name == "search") 
            {
                Connection con = new Connection();
                dt = con.selectt("select * from staff where staff_id not in (select emp_id from user);");
                dv = new DataView(dt);
            }
            else
            {
                dt = emp.selct_employee();
                dv = new DataView(dt);
            }
            //=================================================================

            if (dt.Rows.Count > 0)
            {
                emp_id = dt.Rows[dt.Rows.Count - 1][0].ToString();
            }
            else
            {
                emp_id = "E_100";
            }
            try
            {
                dgv_employee.DataSource = dv;
                dgv_employee.Columns[0].HeaderText = "الكود";
                dgv_employee.Columns[1].HeaderText = "الاسم";
                dgv_employee.Columns[2].HeaderText = "النوع";
                dgv_employee.Columns[8].HeaderText = "الهاتف";
               // dgv_employee.Columns[].HeaderText = "نوع الوظيفة";
                dgv_employee.Columns[3].Visible = false;
                dgv_employee.Columns[4].Visible = false;
                dgv_employee.Columns[5].Visible = false;
                dgv_employee.Columns[6].Visible = false;
                dgv_employee.Columns[7].Visible = false;
                dgv_employee.Columns[9].Visible = false;
                dgv_employee.Columns[10].Visible = false;
                dgv_employee.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            add_employee frm = new add_employee();
            frm.Text = "اضافة موظف جديد";
            frm.Name = "add_employee";
            frm.txt_id.Text = increasekey(emp_id);
            frm.ShowDialog();
            this.frm_employee_Load(sender, e);

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_employee.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف الموظف المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (con.ExecuteQuery("DELETE FROM `clinic`.`staff` WHERE staff_id='"
                            + dgv_employee.CurrentRow.Cells[0].Value.ToString()+"';")==1)
                        {
                            frm_employee_Load(sender, e);
                            MessageBox.Show("تم الحذف بنجاح ");
                        }
                        else if(con.ExecuteQuery("DELETE FROM `clinic`.`staff` WHERE staff_id='"
                            + dgv_employee.CurrentRow.Cells[0].Value.ToString()+"';")==1451)
                        {
                            MessageBox.Show("عفوا لا يمكن حذف هذا الموظف لانه مرتبط بعمليات اخرى داخل النظام  ","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(con.ExecuteQuery(@"DELETE FROM `clinic`.`staff` WHERE staff_id='"
                            + dgv_employee.CurrentRow.Cells[0].Value.ToString() + "';").ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("تم حذف جميع المرضى ", "انتبه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            add_employee frm = new add_employee();
            frm.Text = "تعديل بيانات الموظف";
            frm.Name = "update_employee";
            frm.txt_id.Text = dgv_employee.CurrentRow.Cells[0].Value.ToString();
            frm.txt_name.Text = dgv_employee.CurrentRow.Cells[1].Value.ToString();
            frm.txt_nat_id.Text = dgv_employee.CurrentRow.Cells[10].Value.ToString();
            if (dgv_employee.CurrentRow.Cells[2].Value.ToString() == "ذكر")
            {
                frm.rdb_male.Checked = true;
            }
            else
            {
                frm.rdb_female.Checked = true;
            }
            if (dgv_employee.CurrentRow.Cells[5].Value.ToString().Substring(0, 4) == "ارمل")
            {
                frm.rdb_armal.Checked = true;
            }
            else if (dgv_employee.CurrentRow.Cells[5].Value.ToString().Substring(0, 4) == "اعزب")
            {
                frm.rdb_single.Checked = true;
            }
            else if (dgv_employee.CurrentRow.Cells[5].Value.ToString().Substring(0, 5) == "متزوج")
            {

                frm.rdb_mairried.Checked = true;
            }
            else
            {
                frm.rdb_motalk.Checked = true;
            }
            frm.dtp_birth_date.Value = Convert.ToDateTime(dgv_employee.CurrentRow.Cells[3].Value.ToString());
            //MessageBox.Show(dgv_employee.CurrentRow.Cells[4].Value.ToString());
            frm.dtb_reg_date.Value = Convert.ToDateTime(dgv_employee.CurrentRow.Cells[4].Value.ToString());
            frm.txt_address.Text = dgv_employee.CurrentRow.Cells[6].Value.ToString();
            frm.txt_phone1.Text = dgv_employee.CurrentRow.Cells[8].Value.ToString();
            //frm.txt_phone2.Text = dgv_employee.CurrentRow.Cells[8].Value.ToString();
            frm.txt_email.Text = dgv_employee.CurrentRow.Cells[7].Value.ToString();
            frm.ShowDialog();
            this.frm_employee_Load(sender, e);
        }

        private void txt_search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_search.Text == "ادخل نص البحث")
            {
                txt_search.Clear();
                txt_search.ForeColor = Color.Black;
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "ادخل نص البحث";
                txt_search.ForeColor = Color.LightGray;
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (txt_search.Text != "ادخل نص البحث")
                {



                    if (rdb_id.Checked)
                    {
                        dv.RowFilter = "staff_id like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_employee.DataSource = dv;
                    }
                    else if (rdb_name.Checked)
                    {
                        dv.RowFilter = "staff_name like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_employee.DataSource = dv;
                    }
                    else if (rdb_phone.Checked)
                    {
                        dv.RowFilter = "staff_contact_no like '%" + txt_search.Text + "%'";// dt.Columns[1] + "like '%" + txt_search.Text + "%'";
                        dgv_employee.DataSource = dv;
                    }
                }
                else
                {
                    dgv_employee.DataSource = dv;
                }
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.ForeColor = Color.Black;
        }

        private void rdb_phone_CheckedChanged(object sender, EventArgs e)
        {
            txt_search.Text = "ادخل نص البحث";
            if (dgv_employee.Rows.Count > 0)
            {
                dv.RowFilter = string.Empty;
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            id = dgv_employee.CurrentRow.Cells[0].Value.ToString();
            name = dgv_employee.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void dgv_employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Name == "search")
            {
                id = dgv_employee.CurrentRow.Cells[0].Value.ToString();
                name = dgv_employee.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }
        Connection con = new Connection();
        void loadPriv()
        {
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=2 and priv_user_id='" + Main_Form.curnt_user + "';");
            try
            {
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                    btn_add.Enabled = false;
                }
                if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                {
                    btn_delete.Enabled = false;
                }
                if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                {
                    btn_edit.Enabled = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void frm_employee_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                btn_add_Click(sender, e);
            }
           else if (e.KeyCode == Keys.F2)
            {
                btn_edit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3 || e.KeyCode == Keys.Delete)
            {
                btn_delete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            //else 
            //{
            //    System.Media.SystemSounds.Beep.Play();
            //}
        }
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rdb_phone.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (rdb_name.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (rdb_id.Checked) 
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 'E' && e.KeyChar != '_')
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '_') && ((sender as TextBox).Text.IndexOf('_') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == 'E') && ((sender as TextBox).Text.IndexOf('E') > -1))
                {
                    e.Handled = true;
                }
            }

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                // cancel the "paste" function
                e.SuppressKeyPress = true;
            }
        }

    }
}
