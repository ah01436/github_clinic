using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_exposure : Form
    {
        Connection con = new Connection();
        DataTable dt;
        int v_id;
        bool isopen = true;
        public frm_exposure()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_exposure_Load(object sender, EventArgs e)
        {
            try
            {
                //load patient
                dt = new DataTable();
                dt = con.selectt("select visits.id, patient.patient_name from patient,visits where visits.pat_id=patient.patient_id and isopen =false;");
                dgv_patient.DataSource = dt;
                dgv_patient.Columns[0].Visible = false;
                dgv_patient.Columns[1].HeaderText = "اسم المريض";
                //load diagnosis
                dt = new DataTable();
                dt = con.selectt("select * from diagnosis");
                dgv_diagnosis.DataSource = dt;
                dgv_diagnosis.Columns[0].Visible = false;
                dgv_diagnosis.Columns[1].HeaderText = "اسم التحليل";
                //load drug
                dt = new DataTable();
                dt = con.selectt("SELECT item_id,item_name FROM inventory;");
                dgv_drug.DataSource = dt;
                dgv_drug.Columns[0].Visible = false;
                dgv_drug.Columns[1].HeaderText = "اسم الدواء";
                //load rays
                dt = new DataTable();
                dt = con.selectt("SELECT * FROM clinic.rays;");
                dgv_rays.DataSource = dt;
                dgv_rays.Columns[0].Visible = false;
                dgv_rays.Columns[1].HeaderText = "اسم الاشعة";
                //load personification
                dt = new DataTable();
                dt = con.selectt("SELECT * FROM clinic.personification;");
                dgv_personification.DataSource = dt;
                dgv_personification.Columns[0].Visible = false;
                dgv_personification.Columns[1].HeaderText = "اسم الاشعة";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_patient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            v_id = int.Parse(dgv_patient.CurrentRow.Cells[0].Value.ToString());
            txt_patName.Text = dgv_patient.CurrentRow.Cells[1].Value.ToString();
            list_diagnosis.Items.Clear();
            list_drug.Items.Clear();
            list_personification.Items.Clear();
            list_rays.Items.Clear();
        }

        private void dgv_personification_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_patName.Text == "")

                MessageBox.Show("من فضلك قم باختيار اسم المريض");
            else
            list_personification.Items.Add(dgv_personification.CurrentRow.Cells[1].Value.ToString());
        }

        private void dgv_rays_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_patName.Text == "")

                MessageBox.Show("من فضلك قم باختيار اسم المريض");
            else
            list_rays.Items.Add(dgv_rays.CurrentRow.Cells[1].Value.ToString());

        }

        private void dgv_diagnosis_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_patName.Text == "")

                MessageBox.Show("من فضلك قم باختيار اسم المريض");
            else
            list_diagnosis.Items.Add(dgv_diagnosis.CurrentRow.Cells[1].Value.ToString());
        }

        private void dgv_drug_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_patName.Text == "")
           
                MessageBox.Show("من فضلك قم باختيار اسم المريض");
            else
                list_drug.Items.Add(dgv_drug.CurrentRow.Cells[1].Value.ToString());
            
        }

        private void list_personification_DoubleClick(object sender, EventArgs e)
        {
            list_personification.Items.Remove(list_personification.Items[list_personification.SelectedIndex]);

        }

        private void list_rays_DoubleClick(object sender, EventArgs e)
        {
            list_rays.Items.Remove(list_rays.Items[list_rays.SelectedIndex]);

        }

        private void list_diagnosis_DoubleClick(object sender, EventArgs e)
        {
            list_diagnosis.Items.Remove(list_diagnosis.Items[list_diagnosis.SelectedIndex]);
        }

        private void list_drug_DoubleClick(object sender, EventArgs e)
        {
            list_drug.Items.Remove(list_drug.Items[list_drug.SelectedIndex]);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
               string personification = "";
               string rays="";
               string diagnosis="";
               string drug = "";
            if (txt_patName.Text == "")
            { MessageBox.Show("من فضلك قم باختيار اسم المريض"); }
            else
            { 
            int i;
            //store personification
            for ( i = 0; i < list_personification.Items.Count; i++)
            {

                if (i == list_personification.Items.Count-1)
                    personification += list_personification.Items[i].ToString(); 
                else
                    personification += list_personification.Items[i].ToString() + ",";
            }
            //store rays
            for (i = 0; i < list_rays.Items.Count; i++)
            {

                if (i == list_rays.Items.Count - 1)
                    rays += list_rays.Items[i].ToString();
                else
                    rays += list_rays.Items[i].ToString() + ",";
            }
            //store diagnosis
            for (i = 0; i < list_diagnosis.Items.Count; i++)
            {

                if (i == list_diagnosis.Items.Count - 1)
                    diagnosis += list_diagnosis.Items[i].ToString();
                else
                    diagnosis += list_diagnosis.Items[i].ToString() + ",";
            }
            //store drug
            for (i = 0; i < list_drug.Items.Count; i++)
            {

                if (i == list_drug.Items.Count - 1)
                    drug += list_drug.Items[i].ToString();
                else
                    drug += list_drug.Items[i].ToString() + ",";
            }
            if (con.ExecuteQueries("insert into exposure(v_id,personification,rays,diagnosis,drug) values (" + v_id + ",'" + personification + "','" + rays + "','" + diagnosis + "','" + drug + "')"))
            {
                if (con.ExecuteQueries("update visits set isopen="+isopen+",detection_done="+true+" where id="+v_id+";"))
                MessageBox.Show("تمت الاضافة بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            //load patient
            dt = new DataTable();
            dt = con.selectt("select visits.id, patient.patient_name from patient,visits where visits.pat_id=patient.patient_id and isopen =false;");
            dgv_patient.DataSource = dt;
            dgv_patient.Columns[0].Visible = false;
            dgv_patient.Columns[1].HeaderText = "اسم المريض";
            }
        }

        private void rdb_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_yes.Checked)
            {
                isopen = true;
            }
            else
                isopen = false;
        }
    }
}
