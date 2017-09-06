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
   
    public partial class frm_Open_Visit : Form
    {
        Connection con = new Connection();
        DataTable dt;
        string pat_code;
        string v_date = DateTime.Now.Date.ToString("yyyy-MM-dd");
        
        public frm_Open_Visit()
        {
            InitializeComponent();
        }
      
        private void add_item_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Visit_type frm = new frm_Visit_type();
                frm.ShowDialog();
                dt = new DataTable();
                dt = con.selectt("select v_id,v_name from visit_type;");
                cmb_visit_type.DataSource = dt;
                cmb_visit_type.ValueMember = "v_id";
                cmb_visit_type.DisplayMember = "v_name";
                if (dt.Rows.Count > 0)
                    cmb_visit_type.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_Open_Visit_Load(object sender, EventArgs e)
        {
            try
            {
                //load cmb_visit_type
                dt = new DataTable();
                dt = con.selectt("select v_id,v_name from visit_type;");
                cmb_visit_type.DataSource = dt;
                cmb_visit_type.ValueMember = "v_id";
                cmb_visit_type.DisplayMember = "v_name";
                if (dt.Rows.Count > 0)
                    cmb_visit_type.SelectedIndex = 0;
                //load cmb_doc
                dt = con.selectt("select staff_id,staff_name from staff where staff_position='دكتور';");
                cmb_doc.DataSource = dt;
                cmb_doc.ValueMember = "staff_id";
                cmb_doc.DisplayMember = "staff_name";
                if (dt.Rows.Count > 0)
                    cmb_doc.SelectedIndex = 0;

                //Load DataGridView 
                dt = new DataTable();
                dt = con.selectt(@"select visits.id,patient.patient_name,staff.staff_name,visits.date_visit,visit_type.v_price,user.emp_name
                                from visits,patient,staff,visit_type,user
                                where staff.staff_id=visits.doc_id and patient.patient_id=visits.pat_id and visit_type.v_id =visits.visite_type_code and user.userID=visits.user_id;");
                dgv_visits.DataSource = dt;
                 dgv_visits.Columns[0].Visible = false;
                dgv_visits.Columns[1].HeaderText = "اسم المريض";
                dgv_visits.Columns[2].HeaderText = "الدكتور المعالج";
                dgv_visits.Columns[3].HeaderText = "تاريخ فتح الزيارة";
                dgv_visits.Columns[4].HeaderText = "سعر الزيارة";
                dgv_visits.Columns[5].HeaderText = "موظف الدخول";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_patient frm = new frm_patient();
            frm.Name = "بحث عن مريض";
            frm.btn_add.Visible = false;
            frm.btn_delete.Visible = false;
            frm.btn_edit.Visible = false;
            frm.btn_exit.Visible = false;
            frm.toolStrip_controrl.Hide();
            frm.ShowDialog();
            txt_pat_name.Text = frm_patient.pat_name;
            pat_code = frm_patient.pat_cod;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (con.ExecuteQueries("insert into visits(`pat_id`,`doc_id`,`user_id`,`date_visit`,`visite_type_code`,isopen,detection_done) values('" + pat_code + "','" + cmb_doc.SelectedValue.ToString() + "','" + Main_Form.curnt_user + "','" + v_date + "'," + cmb_visit_type.SelectedValue.ToString() + ",false,false)"))
            {
                MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = new DataTable();
                dt = con.selectt(@"select visits.id,patient.patient_name,staff.staff_name,visits.date_visit,visit_type.v_price,user.emp_name
                                from visits,patient,staff,visit_type,user
                                where staff.staff_id=visits.doc_id and patient.patient_id=visits.pat_id and visit_type.v_id =visits.visite_type_code and user.userID=visits.user_id;");
                dgv_visits.DataSource = dt;
                dgv_visits.Columns[0].Visible = false;
                dgv_visits.Columns[1].HeaderText = "اسم المريض";
                dgv_visits.Columns[2].HeaderText = "الدكتور المعالج";
                dgv_visits.Columns[3].HeaderText = "تاريخ فتح الزيارة";
                dgv_visits.Columns[4].HeaderText = "سعر الزيارة";
                dgv_visits.Columns[5].HeaderText = "موظف الدخول";
            }
        }

        private void toolStrip_controrl_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
       try
            {
                int id = int.Parse(dgv_visits.CurrentRow.Cells[0].Value.ToString());
                if (dgv_visits.Rows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("هل تريد حذف المريض المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (con.ExecuteQueries("delete from visits where id=" + id))
                        {
                            dt = con.selectt(@"select visits.id,patient.patient_name,staff.staff_name,visits.date_visit,visit_type.v_price,user.emp_name
                                from visits,patient,staff,visit_type,user
                                where staff.staff_id=visits.doc_id and patient.patient_id=visits.pat_id and visit_type.v_id =visits.visite_type_code and user.userID=visits.user_id;");
                            dgv_visits.DataSource = dt;
                            dgv_visits.Columns[0].Visible = false;
                            dgv_visits.Columns[1].HeaderText = "اسم المريض";
                            dgv_visits.Columns[2].HeaderText = "الدكتور المعالج";
                            dgv_visits.Columns[3].HeaderText = "تاريخ فتح الزيارة";
                            dgv_visits.Columns[4].HeaderText = "سعر الزيارة";
                            dgv_visits.Columns[5].HeaderText = "موظف الدخول";
                            MessageBox.Show("تم الحذف بنجاح ");
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}