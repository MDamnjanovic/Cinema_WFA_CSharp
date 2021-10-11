using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{

    public class Administrator : User
    {
        string emailAddress;
        string password;
        public Administrator(int uniqueId, string firstName, string lastName, DateTime birthDate, string contactNumber, string sex, string emailAddress, string password)
        {
            this.EmailAddress = emailAddress;
            this.Password = password;

        }

        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Password { get => password; set => password = value; }
    }
}
