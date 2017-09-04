using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    class Patient
    {
        Connection con = new Connection();
        int exp_num;// execption number 
        public DataTable selct_patient()
        {
            DataTable dt = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("p_type", MySqlDbType.VarChar, 20);
            param[0].Value = "patient";
            dt = con.ReadData("sp_select", param);
            return dt;
        }
        // add new patient
        #region add_patient

        public bool insertdata
            (string id,string name,string gender,string birth_date,
            string status,string reg_date,string address,string phone1,
            string phone2,string email,string transformer)
        {
        asd: try
            {
                MySqlParameter[] param = new MySqlParameter[14];
                param[0] = new MySqlParameter("stype", MySqlDbType.VarChar, 20);
                param[0].Value = "patient";
                param[1] = new MySqlParameter("sid", MySqlDbType.VarChar, 20);
                param[1].Value = id;
                param[2] = new MySqlParameter("sname", MySqlDbType.VarChar, 50);
                param[2].Value = name;
                param[3] = new MySqlParameter("sgender", MySqlDbType.VarChar, 10);
                param[3].Value = gender;
                param[4] = new MySqlParameter("sbirth_date", MySqlDbType.Date);
                param[4].Value = birth_date;
                param[5] = new MySqlParameter("sstatus", MySqlDbType.VarChar, 10);
                param[5].Value = status;
                param[6] = new MySqlParameter("sreg_date", MySqlDbType.Date);
                param[6].Value = reg_date;
                param[7] = new MySqlParameter("saddress", MySqlDbType.VarChar, 100);
                param[7].Value = address;
                param[8] = new MySqlParameter("sphone1", MySqlDbType.VarChar, 20);
                param[8].Value = phone1;
                param[9] = new MySqlParameter("sphone2", MySqlDbType.VarChar, 20);
                param[9].Value = phone2;
                param[10] = new MySqlParameter("semail", MySqlDbType.VarChar, 20);
                param[10].Value = email;

                param[11] = new MySqlParameter("sposition", MySqlDbType.VarChar, 10);
                param[11].Value = DBNull.Value;
                param[12] = new MySqlParameter("snat_id", MySqlDbType.VarChar, 14);
                param[12].Value = DBNull.Value;
                param[13] = new MySqlParameter("transformers_id", MySqlDbType.UInt16,11);
                param[13].Value = int.Parse(transformer);
                exp_num = con.Exacute_procdure("sp_add", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
                    if (exp_num == 1062)
                    {
                        id = increasekey(id);
                        goto asd;
                    }
                    MessageBox.Show(exp_num.ToString());
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
#endregion
        // add new patient
        #region update_patient

        public bool update_patient
            (string id, string name, string gender, string birth_date,
            string status, string reg_date, string address, string phone1,
            string phone2, string email)
        {
        asd: try
            {
                MySqlParameter[] param = new MySqlParameter[10];
                param[0] = new MySqlParameter("id", MySqlDbType.VarChar, 20);
                param[0].Value = id;
                param[1] = new MySqlParameter("name", MySqlDbType.VarChar, 50);
                param[1].Value = name;
                param[2] = new MySqlParameter("gender", MySqlDbType.VarChar, 10);
                param[2].Value = gender;
                param[3] = new MySqlParameter("birth_date", MySqlDbType.Date);
                param[3].Value = birth_date;
                param[4] = new MySqlParameter("status", MySqlDbType.VarChar, 10);
                param[4].Value = status;
                param[5] = new MySqlParameter("reg_date", MySqlDbType.Date);
                param[5].Value = reg_date;
                param[6] = new MySqlParameter("address", MySqlDbType.VarChar, 100);
                param[6].Value = address;
                param[7] = new MySqlParameter("phone1", MySqlDbType.VarChar, 20);
                param[7].Value = phone1;
                param[8] = new MySqlParameter("phone2", MySqlDbType.VarChar, 20);
                param[8].Value = phone2;
                param[9] = new MySqlParameter("email", MySqlDbType.VarChar, 45);
                param[9].Value = email;
                exp_num = con.Exacute_procdure("update_patient", param);
                if (exp_num == 1)
                {
                    return true;
                }
                else
                {
                    if (exp_num == 1062)
                    {
                        id = increasekey(id);
                        goto asd;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        //delete patient
        public bool delete_patient(string id)
        {
            try
            {
                MySqlParameter[] param = new MySqlParameter[2];
                param[0] = new MySqlParameter("stype", MySqlDbType.VarChar, 20);
                param[0].Value = "patient";
                param[1] = new MySqlParameter("sid", MySqlDbType.VarChar, 20);
                param[1].Value = id;
                con.Exacute_procdure("sp_delete",param);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public string increasekey(string id)
        {
            string new_id="P_";
           new_id+= (Convert.ToInt64(id.Substring(2, id.Length-2))+1).ToString();
           MessageBox.Show(new_id);
            return new_id;
        }
    }
}
