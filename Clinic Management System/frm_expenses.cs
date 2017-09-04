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
    public partial class frm_Add : Form
    {
        Connection con = new Connection();
        DataTable dt ;
      
        string item = "";
        public frm_Add()
        {
            InitializeComponent();
            loadPriv();
        }
        private void add_item_Click(object sender, EventArgs e)
        {
            item_expense frm = new item_expense();
            frm.ShowDialog();
            frm_expenses_Load(sender,e);
            //dt.Clear();
            //dt = con.selectt("select * from item_expense;");
            //cmb_items.DataSource = dt;
            //cmb_items.ValueMember = "id";
            //cmb_items.DisplayMember = "name";
        }

        private void frm_expenses_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
           
            dt = con.selectt("select * from expenses;");
            dgv_expenses.DataSource = dt;
            dgv_expenses.Columns[0].HeaderText = "الكود";
            dgv_expenses.Columns[1].HeaderText = "كود العنصر";
            dgv_expenses.Columns[2].HeaderText = "التاريخ";
            dgv_expenses.Columns[3].HeaderText = "السعر";
            dgv_expenses.Columns[4].HeaderText = "ملاحظات";
           // بعرض فى الكومبو بوكش
            dt = new DataTable();
                dt = con.selectt("select * from item_expense;");
            cmb_items.DataSource = dt;
            cmb_items.ValueMember = "id";
            cmb_items.DisplayMember = "name";
            cmb_items.SelectedIndex = 0;
       
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string b_date = dtp_buy.Value.ToString("yyyy-MM-dd");  

            try
            {

                if(this.Name=="frm_Add")
                {
                    if(con.ExecuteQueries("insert into expenses(item_id,expense_date,price,notes) values(" + item + ",'" + b_date + "'," + nud_price.Value.ToString() + ",'" + txt_Notes.Text + "')"))
                    {
                MessageBox.Show("تم الحفظ بنجاح");
                dt = con.selectt("select * from expenses;");
                dgv_expenses.DataSource = dt;
                dgv_expenses.Columns[0].HeaderText = "الكود";
                dgv_expenses.Columns[1].HeaderText = "كود العنصر";
                dgv_expenses.Columns[2].HeaderText = "التاريخ";
                dgv_expenses.Columns[3].HeaderText = "السعر";
                dgv_expenses.Columns[4].HeaderText = "ملاحظات";
                }
                }
                else if(this.Name=="update")
                {
                    if (con.ExecuteQueries("update expenses set item_id =" + item + ",expense_date='" + b_date + "',price=" + decimal.Parse(nud_price.Value.ToString()) + ",notes='" + txt_Notes.Text + "' where id= " + int.Parse(dgv_expenses.CurrentRow.Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("تم حفظ التعديلات بنجاح");
                        dt = con.selectt("select * from expenses;");
                        dgv_expenses.DataSource = dt;
                        dgv_expenses.Columns[0].HeaderText = "الكود";
                        dgv_expenses.Columns[1].HeaderText = "كود العنصر";
                        dgv_expenses.Columns[2].HeaderText = "التاريخ";
                        dgv_expenses.Columns[3].HeaderText = "السعر";
                        dgv_expenses.Columns[4].HeaderText = "ملاحظات";
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = cmb_items.SelectedValue.ToString();  
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد حذف الاسم المحدد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgv_expenses.SelectedRows)
                    {
                        dgv_expenses.Rows.RemoveAt(item.Index);
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
            dt = con.selectt("select * from item_expense ");

            this.cmb_items.DataSource = dt;
            this.cmb_items.ValueMember = "id";
            this.cmb_items.DisplayMember = "name";
            this.cmb_items.SelectedValue = dgv_expenses.CurrentRow.Cells[1].Value.ToString();
            dtp_buy.Text = dgv_expenses.CurrentRow.Cells[2].Value.ToString();
            nud_price.Value = decimal.Parse(dgv_expenses.CurrentRow.Cells[3].Value.ToString());
            txt_Notes.Text = dgv_expenses.CurrentRow.Cells[4].Value.ToString();
            this.Name = "update";
        }
        void loadPriv()
        {
            dt = new DataTable();
            dt = con.selectt("select priv_add,priv_delete,priv_edit from tb_priv where priv_screen_id=10 and priv_user_id='" + Main_Form.curnt_user + "';");
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
