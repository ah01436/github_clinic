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
    public partial class frm_rays : Form
    {
        Connection con = new Connection();
        DataTable dt = new DataTable();
        public frm_rays()
        {
            InitializeComponent();
            loadPriv();
        }

        private void frm_rays_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from rays");

            {
                dgv_rays.DataSource = dt;
                dgv_rays.Columns[0].ReadOnly = true;
                dgv_rays.Columns[0].Width = 75;
                dgv_rays.Columns[0].HeaderText = "الكود";
                dgv_rays.Columns[1].HeaderText = "الاسم";
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
                    foreach (DataGridViewRow item in this.dgv_rays.SelectedRows)
                    {
                        dgv_rays.Rows.RemoveAt(item.Index);
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

        private void dgv_rays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgv_rays.CurrentCell.ColumnIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                }
            }
        }

        private void dgv_rays_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dgv_rays_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }
        void loadPriv()
        {
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=7 and priv_user_id='" + Main_Form.curnt_user + "';");
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
