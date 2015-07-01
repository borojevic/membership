using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1
{
    public class FunctionClass
    {
        public static string cnnstring = "data source=TADI;Integrated Security=Yes;Database=dp-gold-membership";
            //ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.DefaultConnection"].ToString();
        public static SqlConnection con = new SqlConnection(cnnstring);


        public static void testConnection()
        {
            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception e)
            {

            }
        }
        //proba

        public static void Insert_User(String name, String surname, String mail, Byte[] photo, String phone, DateTime dateOfBirth, DateTime memberSince)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@photo", photo);
            //SqlParameter param1 = new SqlParameter("photo", photo.ToArray());
            //cmd.Parameters.Add(param1);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@memberSince", memberSince);
       
     
     
       // SqlParameter param1 = new SqlParameter("name", name);
       // cmd.Parameters.Add(param1);
       

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                //EnterLog(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        
        
        //

    }
}
