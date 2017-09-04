using System.Data;
using MySql.Data.MySqlClient;

namespace Clinic_Management_System
{
    class clinic_information
    {
        Connection con=new Connection();
        public bool check_clinic_info()
        {
            DataTable dt = new DataTable();
            dt = con.ReadData("select_clinic_info");
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public DataTable selct_clinic_info()
        {
            DataTable dt = new DataTable();
            dt = con.ReadData("select_clinic_info");
            return dt;
        }
        public bool insertdata(string name,string doctor,string address,string telephone,
            string mobile,string fax,string email,string website,string fb_page)
        {
            if (check_clinic_info())
            {
                
                MySqlParameter[] param = new MySqlParameter[10];
                param[0] = new MySqlParameter("sname", MySqlDbType.VarChar, 50);
                param[0].Value = name;
                param[1] = new MySqlParameter("sdoctor", MySqlDbType.VarChar, 50);
                param[1].Value = doctor;
                param[2] = new MySqlParameter("saddress", MySqlDbType.VarChar, 50);
                param[2].Value = address;
                param[3] = new MySqlParameter("stelephone", MySqlDbType.VarChar, 14);
                param[3].Value = telephone;
                param[4] = new MySqlParameter("smobile", MySqlDbType.VarChar, 14);
                param[4].Value = mobile;
                param[5] = new MySqlParameter("sfax", MySqlDbType.VarChar, 50);
                param[5].Value = fax;
                param[6] = new MySqlParameter("semail", MySqlDbType.VarChar, 50);
                param[6].Value = email;
                param[7] = new MySqlParameter("swebsite", MySqlDbType.VarChar, 50);
                param[7].Value = website;
                param[8] = new MySqlParameter("sfb_page", MySqlDbType.VarChar, 100);
                param[8].Value = fb_page;
                param[9] = new MySqlParameter("stype", MySqlDbType.VarChar, 20);
                param[9].Value = "add";
                if (con.Exacute_procdure("clinic_info", param) == 1)
                {
                    return true;
                }

            } 
            else
            {

                MySqlParameter[] param = new MySqlParameter[10];
                param[0] = new MySqlParameter("sname", MySqlDbType.VarChar, 50);
                param[0].Value = name;
                param[1] = new MySqlParameter("sdoctor", MySqlDbType.VarChar, 50);
                param[1].Value = doctor;
                param[2] = new MySqlParameter("saddress", MySqlDbType.VarChar, 50);
                param[2].Value = address;
                param[3] = new MySqlParameter("stelephone", MySqlDbType.VarChar, 14);
                param[3].Value = telephone;
                param[4] = new MySqlParameter("smobile", MySqlDbType.VarChar, 14);
                param[4].Value = mobile;
                param[5] = new MySqlParameter("sfax", MySqlDbType.VarChar, 50);
                param[5].Value = fax;
                param[6] = new MySqlParameter("semail", MySqlDbType.VarChar, 50);
                param[6].Value = email;
                param[7] = new MySqlParameter("swebsite", MySqlDbType.VarChar, 50);
                param[7].Value = website;
                param[8] = new MySqlParameter("sfb_page", MySqlDbType.VarChar, 100);
                param[8].Value = fb_page;
                param[9] = new MySqlParameter("stype", MySqlDbType.VarChar, 20);
                param[9].Value = "update";
                if (con.Exacute_procdure("clinic_info", param) == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
