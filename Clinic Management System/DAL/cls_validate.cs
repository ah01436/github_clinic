using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
namespace Clinic_Management_System
{
    class cls_validate
    {
        // this funcation use to in crease the key 
        public static string increasekey(string id,int length)
        {
            string new_id = id.Substring(0,length);
            new_id += (Convert.ToInt64(id.Substring(length, id.Length - length)) + 1).ToString();
            return new_id;
        }
        // check if the email is valide or no  
        public  bool IsValidEmail(string email)
        {
            if(!Regex.IsMatch(email,@"/^[\x20-\x7E]+$/"))
            { 
            if (Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                return true;
            else
                return false;
            }
            MessageBox.Show("يجب ادخال الايميل باللغة الانجليزية فقط");
            return false;
        }
        public static bool IsValidNationalID(string id)
        {
            if (id.Length < 14)
            {
                return false;
            }
            if (id[0] != '2' && id[0] != '3')
            {
                return false;
            }
            if (id[1] == '0' && id[2] == '0')
            {
                return false;
            }
            if(id[3]!='0'&&id[3]!='1')
            {
                return false;
            }
            if (id[3] == '1')
            {
                if (id[4] != '0' && id[4] != '1' && id[4] != '2')
                {
                    return false;
                }
            }
            if (id[5] != '0' && id[5] != '1' && id[5] != '2' && id[5] != '3')
            {
                return false;
            }
            if (id[5] == '3')
            {
                if (id[6] != '0' && id[6] != '1')
                {
                    return false;
                }
            }
            if (id[3] == '0'&&id[4]=='2')
            {
                if (id[5] == '3')
                {
                    return false;
                }
            }
            if (id[7] != '0' && id[7] != '1' && id[7] != '2' && id[7] != '3')
            {
                return false;
            }
            return true;

        }
        public static bool IsvalidPhone(string phone)
        {
        Regex phoneNumpattern = new Regex(@"^01[0-2][0-9]{8}$");
            if (phoneNumpattern.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public static bool letterValidation(string txt)
        {
            if (txt.All(c=>Char.IsLetter(c) || c==' '))

                return true;
            else
                return false;

        
        }
        public static bool HasArabicCharacters(string text)
        {

            Regex regex = new Regex(

                "[\u0600-\u06ff]|[\u0750-\u077f]|[\ufb50-\ufc3f]|[\ufe70-\ufefc]");

            return regex.IsMatch(text);
        }


        }
    }