using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Member : User
    {
        string emailAddress;
        string password;

        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Password { get => password; set => password = value; }
        public List<Reservation> LstRes_PerMember { get => lstRes_PerMember; set => lstRes_PerMember = value; }

        public Member (int uniqueId, string firstName, string lastName, DateTime birthDate, string contactNumber, string sex, string emailAddress, string password)
        {
            this.EmailAddress = emailAddress;
            this.Password = password;
            base.UniqueId = uniqueId;
            base.FirstName = firstName;
            base.LastName = lastName;
            base.BirthDate = birthDate;
            base.ContactNumber = contactNumber;
            base.Sex = sex;
        }

        public Member(Member member) 
        {
            this.UniqueId = member.UniqueId;
            this.FirstName = member.FirstName;
            this.LastName = member.LastName;
            this.BirthDate = member.BirthDate;
            this.ContactNumber = member.ContactNumber;
            this.Sex = member.Sex;
            this.EmailAddress = member.EmailAddress;
            this.Password = member.Password;
        }
        public Member()
        {

        }

        List<Reservation> lstRes_PerMember = new List<Reservation>();


        public int getMemberAge (DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            age = age - 1;

            return age;
        }

    }
}
