using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Domain
{
    public class User
    {
        protected uint userID;
        protected string username;
        protected string password;
        protected string role;
        protected string phoneNumber;
        protected string email;

        public User()
        {
            this.userID = 1;
            this.username = "mike";
            this.password = "nebunu";
            this.role = "Administrator";
            this.phoneNumber = "0740123456";
            this.email = "test@gmail.com";
        }

        public User(uint userID, string username, string password, string role, string phoneNumber, string email)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.role = role;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public User(User user)
        {
            this.userID = user.userID;
            this.username = user.username;
            this.password = user.password;
            this.role = user.role;
            this.phoneNumber = user.phoneNumber;
            this.email = user.email;
        }

        public uint UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public override string ToString()
        {
            string s = "Username: " + this.username;
            s += "\nPassword: " + this.password;
            s += "\nRole: " + this.role;
            return s;
        }
    }
}
