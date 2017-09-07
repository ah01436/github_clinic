using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Main_Form : Form
    {
        public static string curnt_user;
        public static string curnt_emp;
        Connection con = new Connection();
        DataTable dt;
        public Main_Form(string user, string emp)
        {
            dt = new DataTable();
            InitializeComponent();
            curnt_user = user;
            curnt_emp = emp;
            dt=con.selectt("select priv_display from tb_priv where priv_user_id='" + user + "'");
            try
            {
                // MessageBox.Show(dt.Rows[0][0].ToString());
                if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                {
                   
                    msPatinet.Enabled = false;
                }
                if (dt.Rows[1][0].ToString() == "False" || dt.Rows[1][0].ToString() == string.Empty)
                {

                    msManageStaff.Enabled = false;
                }
                if (dt.Rows[2][0].ToString() == "False" || dt.Rows[2][0].ToString() == string.Empty)
                {

                    msSuppliers.Enabled = false;
                }
                if (dt.Rows[3][0].ToString() == "False" || dt.Rows[3][0].ToString() == string.Empty)
                {

                    إدارةالمستخدمينToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[4][0].ToString() == "False" || dt.Rows[4][0].ToString() == string.Empty)
                {

                    add_type_of_visit.Enabled = false;
                }
                if (dt.Rows[5][0].ToString() == "False" || dt.Rows[5][0].ToString() == string.Empty)
                {

                    ادارةالاجهزةToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[6][0].ToString() == "False" || dt.Rows[6][0].ToString() == string.Empty)
                {

                    ادارةالاشعةToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[7][0].ToString() == "False" || dt.Rows[7][0].ToString() == string.Empty)
                {

                    ادارةالتحاليلToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[8][0].ToString() == "False" || dt.Rows[8][0].ToString() == string.Empty)
                {

                    بنودالمصروفاتToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[9][0].ToString() == "False" || dt.Rows[9][0].ToString() == string.Empty)
                {

                    المصروفاتToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[10][0].ToString() == "False" || dt.Rows[10][0].ToString() == string.Empty)
                {

                    المخزنToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[11][0].ToString() == "False" || dt.Rows[11][0].ToString() == string.Empty)
                {

                    المصروفاتToolStripMenuItem1.Enabled = false;
                }
                if (dt.Rows[12][0].ToString() == "False" || dt.Rows[12][0].ToString() == string.Empty)
                {

                    بنودالمصروفاتToolStripMenuItem1.Enabled = false;
                }
                if (dt.Rows[13][0].ToString() == "False" || dt.Rows[13][0].ToString() == string.Empty)
                {

                    المرضىToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[14][0].ToString() == "False" || dt.Rows[14][0].ToString() == string.Empty)
                {

                    الموظفينToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[15][0].ToString() == "False" || dt.Rows[15][0].ToString() == string.Empty)
                {

                    التعريفبالعيادةToolStripMenuItem.Enabled = false;
                }
                if (dt.Rows[16][0].ToString() == "False" || dt.Rows[16][0].ToString() == string.Empty)
                {

                    الموردينToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            //MessageBox.Show(user);

        }
        public Main_Form()
        {
            InitializeComponent();
        }
      
       

        // فتح شاشة تسجيل الدخول
        private void msLogin_Click(object sender, EventArgs e)
        {
            Log_in frm = new Log_in();
            frm.ShowDialog();
        }
        // تحميل استايل النظام
        ToolStripMenuItem temp;
        private void Main_Form_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lb_curent_user.Text = curnt_emp;
           // skinEngine1.SkinFile = "Skins\\"+Properties.Settings.Default.style;
            try
            {
                if (Directory.Exists("Skins"))
                    foreach (string file in Directory.GetFiles("Skins"))
                    {
                        var item = msStyles.DropDownItems.Add(Path.GetFileName(file));
                        item.Click += item_Click;
                        if (Properties.Settings.Default.style == item.Text)
                        {
                            (item as ToolStripMenuItem).Checked = true;
                            temp = item as ToolStripMenuItem;
                        }
                       
                        
                    }

            }
            catch { }
        }
        // حدث الاستايلات
        void item_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
        //    skinEngine1.SkinFile = "Skins\\" + item.Text;
            
                temp.Checked = false;
                item.Checked = true;
                temp = item;
            
        }

        private void msStyles_Click(object sender, EventArgs e)
        {

           
        }

        // حفظ الاستايل المختار في الاعدادات
        DialogResult dr;
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            dr = DialogResult.OK;
            if (Properties.Settings.Default.formclose == 1)
            {
                dr = MessageBox.Show("هل تريد الخروج من البرنامج ", "تنبيه ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.formclose += 1;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                Properties.Settings.Default.formclose = 1;
            }
            
            //  Properties.Settings.Default.style = Path.GetFileName(skinEngine1.SkinFile);
            Properties.Settings.Default.Save();
            
        }

        // عرض شاشة اعدادات السيرفر
        private void msServerSetting_Click(object sender, EventArgs e)
        {
            frmServerSetting frm = new frmServerSetting();
            frm.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void msClinicInfo_Click(object sender, EventArgs e)
        {
            frm_Clinic_information frm = new frm_Clinic_information();
            frm.ShowDialog();
        }

        private void ms_createBackup_Click(object sender, EventArgs e)
        {
           
        }

        private void msRestore_Click(object sender, EventArgs e)
        {
            
        }

        private void msPatinet_Click(object sender, EventArgs e)
        {
            frm_patient frm = new frm_patient();
            frm.ShowDialog();
        }

        private void msSuppliers_Click(object sender, EventArgs e)
        {
            frm_supplier frm = new frm_supplier();
            frm.Show();
        }

        private void msManageStaff_Click(object sender, EventArgs e)
        {
            frm_employee frm = new frm_employee();
            frm.ShowDialog();
        }

        private void msCheckupManage_Click(object sender, EventArgs e)
        {
            
        }

        private void add_type_of_visit_Click(object sender, EventArgs e)
        {
            frm_Visit_type frm = new frm_Visit_type();
            frm.ShowDialog();
        }


    

      
        private void ادارةالاجهزةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_devices frm = new frm_devices();
            frm.ShowDialog();
        }

        private void ادارةالاشعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rays frm = new frm_rays();
            frm.ShowDialog();
        }

        private void ادارةالتحاليلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_diagnosis frm = new frm_diagnosis();
            frm.ShowDialog();
        }

        private void بنودالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item_expense frm = new item_expense();
            frm.ShowDialog();
        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add frm = new frm_Add();
            frm.ShowDialog();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_user FRM = new frm_user();
            FRM.ShowDialog();
        }

        private void المخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invatory_Add frm = new frm_invatory_Add();
            frm.Show();
        }

        private void المصروفاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_rptExpensives frm = new frm_rptExpensives();
            frm.Show();

        }

        private void بنودالمصروفاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_expenses_item frm = new frm_expenses_item();
            frm.Show();
        }

        private void المرضىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_patient frm = new frm_rpt_patient();
            frm.Show();
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_employee frm = new frm_rpt_employee();
            frm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void التعريفبالعيادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_clinicIdentification frm = new frm_rpt_clinicIdentification();
            frm.ShowDialog();
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rpt_supplier frm = new frm_rpt_supplier();
            frm.Show();
        }

        private void الصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_priv_user frm = new frm_priv_user();
            frm.ShowDialog();              
        }

        private void مننحنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_About_Us frm = new frm_About_Us();
            frm.ShowDialog();
        }

        private void فتحزيارةلمريضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Open_Visit frm = new frm_Open_Visit();
            frm.Show();
        }

        private void ادخالبياناتزيارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_exposure frm = new frm_exposure();
            frm.Show();
        }

        private void ادارةالتشخيصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_personification frm = new frm_personification();
            frm.Show();
        }

       

        
    }
}
