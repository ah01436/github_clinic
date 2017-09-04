using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_supplier : Form
    {
        Connection con = new Connection();
        DataTable dt=new DataTable();
        cls_validate v = new cls_validate();
        public frm_supplier()
        {
            InitializeComponent();
            loadPriv();
        }

        private void frm_supplier_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from Supplier");
           
            {
                dgv_supplier.DataSource = dt;
                dgv_supplier.Columns[0].ReadOnly = true;
                dgv_supplier.Columns[0].Width = 75;
                dgv_supplier.Columns[0].HeaderText = "كود المورد";
                dgv_supplier.Columns[1].HeaderText = "اسم المورد";
                dgv_supplier.Columns[2].HeaderText = "رقم الهاتف 1";
                dgv_supplier.Columns[3].HeaderText = "رقم الهاتف 2";
                dgv_supplier.Columns[4].HeaderText = "البريد الالكترونى";
                dgv_supplier.Columns[5].HeaderText = "العنوان";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (con.update(dt))
            {
                MessageBox.Show("تم الحفظ بتجاح");
                this.Close();
            }
          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الاسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_supplier.SelectedRows)
                    {
                        dgv_supplier.Rows.RemoveAt(item.Index);
                    }
                    MessageBox.Show("تم الحذف بنجاح ");
                    con.update(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadPriv()
        {
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=3 and priv_user_id='" + Main_Form.curnt_user + "';");
            try
            {
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                    btn_save.Enabled = false;
                }
                if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                {
                    btn_delete.Enabled = false;
                }
                //if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                //{
                //    btn_edit.Enabled = false;
                //}
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
