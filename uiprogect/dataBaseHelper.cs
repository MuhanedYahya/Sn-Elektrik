using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiprogect
{
    public static class dataBaseHelper
    {



        // select
        public static DataTable ExecuteQuery(string Query)
        {
            SqlConnection connection = null;

            try
            {
                string constring = "Server=DESKTOP-T7305OG;Database=Proje-Database;Trusted_Connection=True";
                connection = new SqlConnection(constring);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {                 
                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataAdapter adater = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adater.Fill(dt);
                    return dt;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }



        public static int ExecuteNonQuery(string Query)
        {
            SqlConnection connection = null;

            try
            {
                string constring = "Server=DESKTOP-T7305OG;Database=Proje-Database;Trusted_Connection=True";
                connection = new SqlConnection(constring);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(Query, connection);
                    return command.ExecuteNonQuery();
                }

                else
                {
                    throw new Exception("işleminiz gerçekleşmedi");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }














    }
}
