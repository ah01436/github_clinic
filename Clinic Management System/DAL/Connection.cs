using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace Clinic_Management_System
{
    class Connection
    {
        public string connectionString;
        private MySqlConnection connection;
        public Connection()
        {
            var p = Properties.Settings.Default;
           connectionString = @"SERVER="+p.Server+";DATABASE="+p.database+";uid="+p.uid+" ; pwd="+p.password+";port="+p.port+";";
            connection = new MySqlConnection(connectionString);
        }
        public Connection(string ServerName,string port,string Database,string UserName ,string Password)
        {
            connectionString = @"SERVER=" +ServerName + ";DATABASE=" + Database + ";uid=" + UserName + " ; pwd=" +Password + ";port=" + port+";";
            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        public bool OpenConnection()
        {
            //check connection is close or not 
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 53||ex.Number==1326)
                    {
                        MessageBox.Show("تم فقد الاتصال بقاعدة البيانات السرفر لا يعمل ");
                    }
                    else
                    {
                        MessageBox.Show(ex.Number.ToString());
                        MessageBox.Show(ex.ToString());
                    }
                    return false;
                }
            }
            return true;
        }
        //Close connection
        public void CloseConnection()
        {
            //check connection is open or not 
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();

                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 53 || ex.Number == 1326)
                    {
                        MessageBox.Show("تم فقد الاتصال بقاعدة البيانات السرفر لا يعمل ");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }
        //method to read data from database
        public DataTable ReadData(string stored_procdure, MySqlParameter[] parameter)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                if (parameter != null)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        cmd.Parameters.Add(parameter[i]);
                    }
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable ReadData(string stored_procdure)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;          
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        //method to insert or update or delete data from database 
        public int Exacute_procdure(string stored_procdure, MySqlParameter[] parameter)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                cmd.Connection = connection;
                if (parameter != null)
                {
                    cmd.Parameters.AddRange(parameter);
                }
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch (MySqlException ex)
            {
               // MessageBox.Show(ex.Message);
                return ex.Number;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return 0;
            }
        }
        public void Exacute_procdure(string stored_procdure)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string getid(string tabel)
        {
            string id = "";

            if (true)
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "select count('*') from " + tabel + " ;";
                cmd.Connection = connection;
                try
                {
                    id = cmd.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                //close connection
                finally
                {
                    this.CloseConnection();
                }

            }

            return id;
        }
        // convert image to byte - write image in database
        public static byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        // convert image to image - read image from database
        public static System.Drawing.Image ConvertBytesToImage(byte[] byt)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byt);
            return System.Drawing.Image.FromStream(ms);
        }
        MySqlCommandBuilder CB;
        MySqlDataAdapter adat;
        
        public bool update(DataTable dd)
        {
            try
            {
                CB = new MySqlCommandBuilder(adat);
                adat.Update(dd);
                return true;
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public DataTable selectt(string query)
        {
            DataTable d = new DataTable();

            try
            {
                adat = new MySqlDataAdapter(query,connection);
                adat.Fill(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return d;
        }
        public bool ExecuteQueries(string Query)
        {
            try
            {
                Connection con = new Connection();
                con.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con.connection;
                cmd.CommandText = Query;
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
            return false;

            }
        }

    }
}

