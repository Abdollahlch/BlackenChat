using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace ChatAppBusinessLogic
{
    public class clsMessage
    {
        enum enMode { AddNew,Update};
        enMode _Mode;
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime MessageDate { get; set; }
        


        
       private clsMessage(int MessageID, string MessageContent,int SenderID,int ReceiverID,DateTime time)
        {
            this.MessageID = MessageID;
            this.Content = MessageContent;
            this.MessageDate = time;
            this.ReceiverID = ReceiverID;
            this.SenderID = SenderID;
            
        }
        public clsMessage()
        {
            this.MessageID = -1;
            this.Content = "";
            this.MessageDate = DateTime.Now;
            this.ReceiverID = -1;
            this.SenderID = -1;
        }

        bool _AddNewMessage()
        {
            this.MessageID = MessageDataAccess.AddNewMessage(Content, SenderID, ReceiverID, MessageDate);
            return (this.MessageID != -1);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMessage())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }

        bool DeleteMessage(int ID)
        {
            return MessageDataAccess.DeleteMessage(ID);
        }
        public static DataTable GetAllMessages()
        {
            return MessageDataAccess.GetAllMessages();
        }
        
        public static DataTable GetMessagesBetweenUsers(int CurrentUser,int Partner)
        {
            return MessageDataAccess.GetMessagesBetweenUsers(CurrentUser,Partner);
        }

        public static bool DeleteAllMessagesBetweenUserPartner(int CurrentUser,int CurrentPartner)
        {
            return MessageDataAccess.DeleteAllMessagesBetweenUserPartner(CurrentUser, CurrentPartner);
        }
        public static clsMessage FindMessageByID(int id)
        {
            string messageContent = "";
            int senderID = -1;
            int receiverID = -1;
            DateTime TimeStamp = DateTime.Now;
            if (MessageDataAccess.GetMessageInfoByID(id, ref  messageContent, ref  senderID, ref  receiverID,ref TimeStamp))
            {
                return new clsMessage(id, messageContent, senderID, receiverID,TimeStamp);
            }
            else
                return null;
        }
        
        public static clsMessage GetTheLastMessage()
        {
            
            DataTable dt = MessageDataAccess.GetLastMessage();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new clsMessage((int)row["MessageID"], row["Content"].ToString(), (int)row["SenderID"], (int)row["ReceiverID"], (DateTime)row["Timestamp"]);
            }
            else
                return null;
        }

    }
}
