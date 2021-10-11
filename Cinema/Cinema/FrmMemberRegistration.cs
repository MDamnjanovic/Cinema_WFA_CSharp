using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FrmMemberRegistration : Form
    {
        public FrmMemberRegistration()
        {
            InitializeComponent();
            DataElements.initializeLists();
            initializeDate();
        }

        void initializeDate ()
        {
            string youngestBirth = "01/01/2008";
            DateTime maxDate;
            if (DateTime.TryParse(youngestBirth, out maxDate))
            {
                dateTimePicker1.Value = maxDate;
                dateTimePicker1.MaxDate = maxDate;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidateEmail (string email)
        {
            string emailAddress = tbEmailAdress.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailAddress);
            //bool validEmail = false;
            if (match.Success)
                return true;
            else
                return false;
        }
        public bool ValidateNumber (string number)
        {
            bool validNumber = false;
            string contactNumber = tbContactNumber.Text;
            int cNumber;
            bool isNumeric = int.TryParse(contactNumber, out cNumber);
            if (isNumeric)
                validNumber = true;
            

            return validNumber;

        }

        public bool ValidateData ()
        {
            bool validData = false;
            if (ValidateEmail(tbEmailAdress.Text))
            {
                if (ValidateNumber(tbContactNumber.Text))
                {
                    if (tbFirstName.Text != "" && tbPassword.Text != "" && tbLastName.Text != "" && tbSex.Text != "")
                    {
                        validData = true;
                    }
                    else
                        MessageBox.Show("You have left some fields empty. \nPlease fill in all the fields.");

                }
                else
                    MessageBox.Show("Invalid Contact Number format. Only digits are permitted.");

            }
            else
                MessageBox.Show("Invalid E-mail address format. Please try again.");

            return validData;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Member member = DataElements.lstMbr.ElementAt(DataElements.lstMbr.Count - 1);
                int memberId = member.UniqueId + 1;
                string emailAddress = tbEmailAdress.Text;
                string password = tbPassword.Text;
                string contactNumber = tbContactNumber.Text;
                string sex = tbSex.Text;
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                DateTime birthDate = dateTimePicker1.Value;
                Member newMember = new Member(memberId, firstName, lastName, birthDate, contactNumber, sex, emailAddress, password);
                DataElements.lstMbr.Add(newMember);
                string insertData = $"insert into Member1(UniqueMemberId1,FirstName,LastName,BirthDate,ContactNumber,Sex,EmailAddress,Passwrd)"
                                    + $" values({memberId},'{firstName}','{lastName}','{birthDate}','{contactNumber}','{sex}','{emailAddress}','{password}')";
                DbManagement.insert_update_delete(insertData);
                MessageBox.Show("Successful login!");
                DialogResult = DialogResult.OK;


            }
        }

      
    }
}
