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




        //
        // custom functions
        public static long ActivationCodeGenerator()
        {
            Random r = new Random();

            int number = r.Next(999999999);
            int number2 = r.Next(999999);

            return ((long)number2 * (long)1000000000) + (long)number;
        }


        public static Boolean ValidateActivationCode(String activationCode) 
        {
            DataSet ds = FunctionClass.Select_By_ActivationCode(activationCode);
            if (ds.Tables["Data"].Rows.Count == 0)
                return true;
            return false;
        }
        //



//       insert_user

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


//       insert_gold_card


        public static void Insert_GoldCard(DateTime dateFrom, DateTime dateTo, String activationCode, Int32 userId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert_gold_card";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@dateTo", dateTo);
            cmd.Parameters.AddWithValue("@activationCode", activationCode);
            cmd.Parameters.AddWithValue("@userId", userId);
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
//       select_user_by_id     

        public static DataSet Select_User_By_ID(String name, String surname, String mail, String phone, DateTime dateOfBirth)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select_user_by_id";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Data");

            return ds;
        }

//       select_by_activationCode

        public static DataSet Select_By_ActivationCode(String activationCode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select_by_activationCode";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@activationCode", activationCode);
          
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Data");

            return ds;
        }


//      select_goldCard_by_userId

        public static DataSet Select_GoldCard_By_UserID(Int32 id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select_goldCard_by_userId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Data");

            return ds;
        }

//      insert_new_activity

        public static void Insert_Activity(DateTime dateFrom, String serviceId, Int32 userId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert_new_activity";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@serviceId", serviceId);
            cmd.Parameters.AddWithValue("@userId", userId);
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

//      update_user

        public static void Update_User(Int32 id, String name, String surname, String mail, Byte[] photo, String phone, DateTime dateOfBirth)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update_user";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@photo", photo);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

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
        // select_users
        public static DataSet Select_Users_By_SearchString(String searchString)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select_users";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@searchString", searchString);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Data");

            return ds;
        }
        
    }
}
