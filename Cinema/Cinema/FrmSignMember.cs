using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FrmSignInMember : Form
    {
        public FrmSignInMember()
        {
            InitializeComponent();
            DataElements.initializeLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string emailAddress = tbEmailAdress.Text;
            string password = tbPassword.Text;

            Member member = (Member)DataElements.lstMbr.Where(mb => mb.EmailAddress == emailAddress).FirstOrDefault();

            if (member != null)
            {
                if (member.Password == password)
                {
                    FrmAddEditAsMember frmAsMember = new FrmAddEditAsMember(member);
                    frmAsMember.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Sign In Error \n Password or E-mail address you entered is incorrect. \n Please try again");
                    tbEmailAdress.Text = null;
                    tbPassword.Text = null;
                }
            }
            else
            {
                MessageBox.Show(" Sign In Error \n Password or E-mail address you entered is incorrect. \n Please try again");
                tbEmailAdress.Text = null;
                tbPassword.Text = null;
            }

        }
    }
}
