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
    public partial class frm_priv_user : Form
    {
        Connection con = new Connection();
        public frm_priv_user()
        {
            InitializeComponent();
            loadData();
            this.list_user.SelectedIndexChanged += new System.EventHandler(this.list_user_SelectedIndexChanged);
            this.list_lists.SelectedIndexChanged += new System.EventHandler(this.list_user_SelectedIndexChanged);
        }
        private void frm_priv_user_Load(object sender, EventArgs e)
        {
           
           list_user_SelectedIndexChanged(sender, e);
        }
        void loadData()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = con.selectt("select * from user;");
            dt2 = con.selectt("select * from tb_lists;");
            list_user.DataSource = dt1;
            list_user.DisplayMember = "userName";
            list_user.ValueMember = "userID";
            list_lists.DataSource = dt2;
            list_lists.DisplayMember = "list_name";
            list_lists.ValueMember = "list_id";          
        }
        DataTable dts;
        private void list_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dts = new DataTable();
                dts = con.selectt(@"select priv_screen_id,screen_name,priv_display,priv_add,priv_delete,priv_edit 
                                   from tb_priv,tb_screen where tb_priv.priv_screen_id=tb_screen.screen_id and 
                                   tb_screen.list_id=(select list_id from tb_lists where list_id=" + list_lists.SelectedValue + " ) and priv_user_id='" + list_user.SelectedValue.ToString() + "';");
                dgv_priv.DataSource = dts;
                dgv_priv.Columns[0].HeaderText = "رقم الشاشة";
                dgv_priv.Columns[1].ReadOnly=true;
                dgv_priv.Columns[0].Visible = false;
                dgv_priv.Columns[1].HeaderText = "اسم الشاشة";
                dgv_priv.Columns[2].HeaderText = "عرض";
                dgv_priv.Columns[3].HeaderText = "اضافة";
                dgv_priv.Columns[4].HeaderText = "حذف";
                dgv_priv.Columns[5].HeaderText = "تعديل";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            bool ch = false;
            string user_code = list_user.SelectedValue.ToString();
            for (int i = 0; i < dgv_priv.Rows.Count; i++)
            {
                int screen_num =Convert.ToInt32(dgv_priv.Rows[i].Cells[0].Value);
                Boolean dis = dgv_priv.Rows[i].Cells[2].Value.Equals(true || false);
                Boolean add = dgv_priv.Rows[i].Cells[3].Value.Equals(true || false);
                Boolean edit = dgv_priv.Rows[i].Cells[4].Value.Equals(true || false);
                Boolean delete = dgv_priv.Rows[i].Cells[5].Value.Equals(true || false);
                if (con.ExecuteQueries("update tb_priv set priv_display=" + dis + ",priv_add=" + add + ",priv_delete=" + delete + ",priv_edit=" + edit
                    + " where priv_user_id='"+list_user.SelectedValue+"' and priv_screen_id="+screen_num+" ;"))
                {
                    ch = true;
                }
                else
                {
                    ch = false;
                    break;
                }
            }
            if (ch==true)
            {
                 MessageBox.Show("تم الحفظ بنجاح");
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
