using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DBCrud
{
    class DBPrepaidCards
    {
        private static string tablename = "prepaidcards";

        private int id;
        private string cableType;
        private int amount;
        private string pin;
        private string status;
        private DateTime date_registered;
        private DateTime date_expired;

        public int Id
        {
            get{ return id; }
            set { id = value; }
        }

        public string CableType
        {
            get { return cableType; }
            set { cableType = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime Date_Registered
        {
            get { return date_registered; }
            set { date_registered = value; }
        }

        public DateTime Date_Expired
        {
            get { return date_expired; }
            set { date_expired = value; }
        }

         public DBPrepaidCards()
        {

        }

         public DBPrepaidCards(string cableType, int amount, string pin, string status, DateTime date_registered, DateTime date_expired)
        {
           
            this.cableType = cableType;
            this.amount = amount;
            this.pin = pin;
            this.status = status;
            this.date_registered = date_registered;
            this.date_expired = date_expired;
        }

        public void Add()
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@cableType,@amount,@pin,@status,@date_registered,@date_expired)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@cableType",this.CableType);
                cmd.Parameters.AddWithValue("@amount", this.Amount);
                cmd.Parameters.AddWithValue("@pin", this.Pin);
                cmd.Parameters.AddWithValue("@status", this.Status);
                cmd.Parameters.AddWithValue("@date_registered",this.Date_Registered);
                cmd.Parameters.AddWithValue("@date_expired", this.Date_Expired);
               
                cmd.ExecuteNonQuery(); //execute the mysql command
                
                //MessageBox.Show("Insert Successfully !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update()
        {
            string cmdText = "UPDATE " + tablename + " SET  amount = @amount, pin=@pin, status=@status, date_registered=@date_registered, date_expired=@date_expired, cableType=@cableType WHERE id=@id";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@id", this.Id);
                cmd.Parameters.AddWithValue("@cableType", this.CableType);
                cmd.Parameters.AddWithValue("@amount", this.Amount);
                cmd.Parameters.AddWithValue("@pin", this.Pin);
                cmd.Parameters.AddWithValue("@status", this.Status);
                cmd.Parameters.AddWithValue("@date_registered", this.Date_Registered);
                cmd.Parameters.AddWithValue("@date_expired", this.Date_Expired);


                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete()
        {
            MySqlConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE id=@id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@id", this.Id);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(string id)
        {
            MySqlConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE id=@id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static List<DBPrepaidCards> GetData()
        {
            List<DBPrepaidCards> data = new List<DBPrepaidCards>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCards rawData = new DBPrepaidCards();
                        rawData.Id = reader.GetInt32(0);
                        rawData.CableType = reader.GetString(1);
                        rawData.Amount = reader.GetInt32(2);
                        rawData.Pin = reader.GetString(3);
                        rawData.Status = reader.GetString(4);
                        rawData.Date_Registered = reader.GetDateTime(5);
                        rawData.Date_Expired = reader.GetDateTime(6);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }


        public static DBPrepaidCards GetDataByAmount(int amount,string cableType)
        {
            DBPrepaidCards data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT amount,pin,id,cableType FROM " + tablename + " WHERE id=(SELECT MIN(id) from " + tablename + " WHERE cableType='" + cableType + "' AND amount=" + amount + ") ", con);
              
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    reader.Read();
                    data = new DBPrepaidCards();
                    data.Amount = reader.GetInt32(0);
                    data.Pin = reader.GetString(1);
                    data.Id = reader.GetInt32(2);
                    data.CableType = reader.GetString(3);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return data;

        }

        public static DBPrepaidCards GetDataID(int id)
        {
            DBPrepaidCards data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id="+id,con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    reader.Read();
                    
                    data = new DBPrepaidCards();
                    data.Id = reader.GetInt32(0);
                    data.CableType = reader.GetString(1);
                    data.Amount = reader.GetInt32(2);
                    data.Pin = reader.GetString(3);
                    data.Status = reader.GetString(4);
                    data.Date_Registered = reader.GetDateTime(5);
                    data.Date_Expired = reader.GetDateTime(6);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return data;

        }
    
    }
}
