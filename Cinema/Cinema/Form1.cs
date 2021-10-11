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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataElements.initializeLists();
        }

        private void btnSignInAdmin_Click_1(object sender, EventArgs e)
        {
         FrmSignInAdmin frmAdmin = new FrmSignInAdmin();
            frmAdmin.ShowDialog(); 
        }

        private void btnSignInMember_Click(object sender, EventArgs e)
        {
            FrmSignInMember frmMember = new FrmSignInMember();
            frmMember.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FrmMemberRegistration frmMemberRegistration = new FrmMemberRegistration();
            frmMemberRegistration.ShowDialog(); 
            if (frmMemberRegistration.DialogResult == DialogResult.OK)
            {
                DataElements.initializeLists();
            }
        }
    }
}
