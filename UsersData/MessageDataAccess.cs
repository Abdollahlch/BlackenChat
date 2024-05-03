using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccess
{
    public static class MessageDataAccess
    {
        
        
        public static int AddNewMessage(string messageContent, int senderID, int receiverID,DateTime Timestamp)
        {
            int MessageID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Messages 
                            values (@senderID,@receiverID,@Content,@TimeStamp)
                            SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@senderID", senderID);
            cmd.Parameters.AddWithValue("@receiverID", receiverID);
            cmd.Parameters.AddWithValue("@Content", messageContent);
            cmd.Parameters.AddWithValue("@TimeStamp", Timestamp);
            try
            {
                connection.Open();
                object id =cmd.ExecuteScalar();
                if (id != null && int.TryParse(id.ToString(),out int InsertedID))
                {
                    MessageID = InsertedID;
                }
            }
            catch (Exception ex){ Console.WriteLine("Error" + ex.Message); }
            finally { connection.Close(); }
            return MessageID;

        }
        public static bool GetMessageInfoByID(int id, ref
            string messageContent, ref int senderID, ref int receiverID,ref DateTime dateTime)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Messages WHERE MessageID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    messageContent = reader["Content"].ToString();
                    senderID = (int)reader["SenderID"];
                    receiverID = (int)reader["ReceiverID"];
                    dateTime = (DateTime)reader["Timestamp"];
                    isFound= true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }



        public static bool DeleteMessage(int id)
        {
            //create a connection to database and query as string and sqlcommand and try and catch and finally and return true if the message is deleted otherwise return false
            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Messages WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                AffectedRows= command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
            }
            finally
            {
                connection.Close();
            }   
            return (AffectedRows>0);
            
        }
        public static DataTable GetAllMessages()
        {
            DataTable Messages = new DataTable();
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Messages";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                Messages.Load(reader);
                
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Messages;
            
        }
        public static DataTable GetMessagesBetweenUsers(int UserID,int PartnerID)
        {
            DataTable Messages = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM Messages 
                            WHERE (SenderID = @UserID1 AND ReceiverID = @UserID2) OR (SenderID = @UserID2 AND ReceiverID = @UserID1) 
                            ORDER BY Timestamp ";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID1", UserID);
            cmd.Parameters.AddWithValue("@UserID2", PartnerID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                   Messages.Load(reader);
            }
            catch {  }
            finally { connection.Close(); }
            return Messages;
        }

        public static bool DeleteAllMessagesBetweenUserPartner(int UserID, int PartnerID)
        {
            DataTable Messages = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Delete  FROM Messages 
                            WHERE (SenderID = @UserID1 AND ReceiverID = @UserID2) OR (SenderID = @UserID2 AND ReceiverID = @UserID1) 
                             ";
            int AffectedRows = 0;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID1", UserID);
            cmd.Parameters.AddWithValue("@UserID2", PartnerID);
            try
            {
                connection.Open();
                AffectedRows = cmd.ExecuteNonQuery();
               
            }
            catch { }
            finally { connection.Close(); }
            return (AffectedRows>0);
        }

        public static List<int> GetAllPartnersByUserID(int userID)
        {
            List<int> partners = new List<int>();

            string query = @"SELECT DISTINCT 
                            CASE WHEN SenderID = @UserID THEN ReceiverID
                            ELSE SenderID 
                            END AS PartnerID FROM Messages 
                            WHERE SenderID = @UserID OR ReceiverID = @UserID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int partnerID = (int)reader["PartnerID"];
                    partners.Add(partnerID);
                }

                reader.Close();
            }

            return partners;
        }

        public static int GetTotalNumberOfMessages()
        {
            //fill it
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT COUNT(*) FROM Messages";
            SqlCommand command = new SqlCommand(query, connection);
            int count = 0;
            try
            {
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                count = -1;
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        public static DataTable GetLastMessage()
        {
            if (GetTotalNumberOfMessages() == 0)
            {
                return null;
            }
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT TOP 1 * FROM Messages ORDER BY Timestamp DESC";
            SqlCommand cmd = new SqlCommand(Query, connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
            
        }
    }
}
