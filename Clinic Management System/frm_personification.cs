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
    public partial class frm_personification : Form
    {
        Connection con = new Connection();
        DataTable dt;
        public frm_personification()
        {
            InitializeComponent();
        }

        private void frm_personification_Load(object sender, EventArgs e)
        {
            dt = con.selectt("select * from personification");

            {
                dgv_personification.DataSource = dt;
                dgv_personification.Columns[0].ReadOnly = true;
                dgv_personification.Columns[0].Width = 75;
                dgv_personification.Columns[0].HeaderText = "الكود";
                dgv_personification.Columns[1].HeaderText = "اسم التشخيص";
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
                    foreach (DataGridViewRow item in this.dgv_personification.SelectedRows)
                    {
                        dgv_personification.Rows.RemoveAt(item.Index);
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
    }
}
