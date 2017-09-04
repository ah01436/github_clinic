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
    public partial class frm_invatory_Add : Form
    {
        public frm_invatory_Add()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        DataTable dt;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.Name == "frm_invatory_Add")
            {
                if (con.ExecuteQueries("insert into inventory(item_name,item_qty,item_sell_price,item_buy_price,item_function) values('"
                    + txt_name.Text + "'," + num_quantity.Value + "," + nud_sellprice.Value + ","
                    + num_buyPrice.Value + ",'" + txt_functions.Text + "')"))
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    frm_inventoery_Load(sender, e);

                }
            }
            else if (this.Name == "update")
            {
                if (con.ExecuteQueries("update inventory set item_name ='" + txt_name.Text + "',item_qty=" + num_quantity.Value + ",item_sell_price=" + nud_sellprice.Value + ",item_buy_price=" + num_buyPrice.Value + ",item_function='"+txt_functions.Text+"' where item_id= " + int.Parse(dgv_invatory.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("تم حفظ التعديلات بنجاح");
                    frm_inventoery_Load(sender, e);
                }
            }

        }

        private void frm_inventoery_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = con.selectt("select * from inventory;");
            dgv_invatory.ReadOnly = true;
            dgv_invatory.AllowUserToAddRows = false;
            dgv_invatory.AllowUserToDeleteRows = false;
            dgv_invatory.DataSource = dt;
            dgv_invatory.Columns[0].HeaderText = " كود العنصر";
            
            dgv_invatory.Columns[1].HeaderText = "اسم العنصر";
            dgv_invatory.Columns[2].HeaderText = "الكمية";
            dgv_invatory.Columns[3].HeaderText = "سعر الشراء";
            dgv_invatory.Columns[4].HeaderText = "سعر البيع";
            dgv_invatory.Columns[5].HeaderText = "طريقة الاستخدام";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الاسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_invatory.SelectedRows)
                    {
                        dgv_invatory.Rows.RemoveAt(item.Index);
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

        private void dgv_expenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dt = new DataTable();
            dt = con.selectt("select * from inventory ");

            
            this.txt_name.Text = dgv_invatory.CurrentRow.Cells[1].Value.ToString();
            num_quantity.Value =int.Parse(dgv_invatory.CurrentRow.Cells[2].Value.ToString());
            nud_sellprice.Value = decimal.Parse(dgv_invatory.CurrentRow.Cells[3].Value.ToString());
            num_buyPrice.Value = decimal.Parse(dgv_invatory.CurrentRow.Cells[4].Value.ToString());
            txt_functions.Text = dgv_invatory.CurrentRow.Cells[5].Value.ToString();
            this.Name = "update";
        }
        void loadPriv()
        {
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=11 and priv_user_id='" + Main_Form.curnt_user + "';");
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
