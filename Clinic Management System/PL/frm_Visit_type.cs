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
    public partial class frm_Visit_type : Form
    {
        Connection con = new Connection();
        DataTable dt = new DataTable();
        public frm_Visit_type()
        {
            InitializeComponent();
            loadPriv();
        }

        private void frm_Visit_type_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from Visit_type");

            {
                dgv_supplier.DataSource = dt;
                dgv_supplier.Columns[0].ReadOnly = true;
                dgv_supplier.Columns[0].Width = 50;
                dgv_supplier.Columns[2].Width = 75;
                dgv_supplier.Columns[3].Width = 125;
                dgv_supplier.Columns[0].HeaderText = "كود الزيارة";
                dgv_supplier.Columns[1].HeaderText = "اسم الزيارة";
                dgv_supplier.Columns[2].HeaderText = "سعر الزيارة";
                dgv_supplier.Columns[3].HeaderText = "نسبة الممرضة";
                dgv_supplier.Columns[2].DefaultCellStyle.Format = "#.#0";
                dgv_supplier.Columns[3].DefaultCellStyle.Format="#.#0";
         
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
                DialogResult dr = MessageBox.Show("هل تريد حذف الزيارة المحددة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=5 and priv_user_id='" + Main_Form.curnt_user + "';");
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
