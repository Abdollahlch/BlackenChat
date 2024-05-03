using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace ChatAppBusinessLogic
{
    public class clsUser
    {
        enum enMode { AddNew, Update };

        enMode _Mode;
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }

        public string ImagePath { get; set; }

        private clsUser(int UserID,string Username,string Password,string Bio,string ImagePath)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.Bio = Bio;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }
        public clsUser()
        {
            UserID = -1;
            Username = "";
            Password = "";
            Bio = "";
            ImagePath = "";
            _Mode = enMode.AddNew;
        }
        public static clsUser FindByUsername(string Username)
        {
            string Password = "",Bio="",ImagePath="";
            int UserID= 0;
            if (UserDataAccess.GetUserInfoByUsername(Username,ref UserID,ref Password,ref Bio,ref ImagePath))
            {
                return new clsUser(UserID,Username,Password,Bio,ImagePath);
            }
            return null;
        }
          bool _AddNewUser(string Username, string Password,string Bio,string ImagePath)
        {
            return UserDataAccess.AddNewUser(Username,Password,Bio,ImagePath);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    
                if (_AddNewUser(this.Username, this.Password, this.Bio,this.ImagePath))
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                    return false;
                
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return UserDataAccess.GetAllUsers();
        }
         bool _UpdateUser()
        {
            return UserDataAccess.UpdateUser( this.Username, this.Password, this.Bio,this.ImagePath);
        }
        public static bool DeleteUser(string Username)
        {
            return UserDataAccess.DeleteUser(Username);
        }
        public  bool CheckPassword(string Password)
        {
            return UserDataAccess.CheckPassword(this.Username, Password);
        }
        public List<int> GetAllPartnersByUserID()
        {
            
            return MessageDataAccess.GetAllPartnersByUserID(this.UserID);

        }
       public static clsUser FindByID(int id)
        {
            string Username = "", Password = "", Bio = "",ImagePath="";
            if (UserDataAccess.FindByID(id, ref Username, ref Password, ref Bio,ref ImagePath))
            {
                return new clsUser(id, Username, Password, Bio,ImagePath);
            }
            else
                return null;
        }

    }
}
