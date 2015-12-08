using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerGB.Buisness.Models
{
    class User : IUser
    {
        #region Fields
        private readonly string mail;
        private readonly string name;
        private readonly string surname;
        private readonly string userLogin;
        private readonly string userPassword;
        private readonly string defaultValue = "Not set";
        #endregion

        public User(string userLogin, string userPassword, string mail = null, 
                    string name = null, string surname = null)
        {
            if (string.IsNullOrEmpty(userLogin) 
                || string.IsNullOrEmpty(userPassword)
                || string.IsNullOrEmpty(mail))
            {
                throw new ArgumentNullException();
            }
            
            this.name = name ?? DefaultValue;
            this.surname = surname ?? DefaultValue;
            this.userLogin = userLogin;
            this.userPassword = userPassword;
            this.mail = mail;
        }

        
        public string Mail
        {
            get{ return this.mail; }
        } 

        public string Name
        {
            get { return this.name; }
        }

        public string Surname
        {
            get { return this.surname; }
        }

        public string UserLogin
        {
            get { return this.userLogin; }
        }

        public string UserPassword
        {
            get { return this.userPassword; }
        }

        public string DefaultValue
        {
            get { return defaultValue; }
        }
    }
}
