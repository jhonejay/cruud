using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBCrud
{
    class DBConnection
    {
        public static MySqlConnection ConnectDatabase()
        {
            MySqlConnection con = null;
            String connectionStr = @"server=localhost; database=seminar; userid=root; password=; Convert Zero Datetime=True;";

            try
            {
                con = new MySqlConnection(connectionStr);
                con.Open(); //open the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }
    }
}
