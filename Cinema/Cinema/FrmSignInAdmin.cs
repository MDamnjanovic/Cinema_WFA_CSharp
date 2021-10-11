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
    public partial class FrmSignInAdmin : Form
    {
        public FrmSignInAdmin()
        {
            InitializeComponent();
            DataElements.initializeLists();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string emailAddress = tbEmailAdress.Text;
            string password = tbPassword.Text;

            Administrator administrator = (Administrator)DataElements.lstAdm.Where(ad => ad.EmailAddress == emailAddress).FirstOrDefault();

            if (administrator != null)
            {
                if (administrator.Password == password)
                {
                    FrmAddEditAsAdministrator frmAsAdministrator = new FrmAddEditAsAdministrator(administrator);
                    frmAsAdministrator.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Sign In Error \nPassword or E-mail address you entered is incorrect. \nPlease try again");
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
