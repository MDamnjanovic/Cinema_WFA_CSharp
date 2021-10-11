using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class User
    {
        int uniqueId;
        string firstName;
        string lastName;
        DateTime birthDate;
        string contactNumber;
        string sex;

        //public User(int uniqueId, string firstName, string lastName, DateTime birthDate, string contactNumber, string sex)
        //{
        //    this.UniqueId = uniqueId;
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.BirthDate = birthDate;
        //    this.ContactNumber = contactNumber;
        //    this.Sex = sex;
        //}

        public int UniqueId { get => uniqueId; set => uniqueId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Sex { get => sex; set => sex = value; }


    }
}
