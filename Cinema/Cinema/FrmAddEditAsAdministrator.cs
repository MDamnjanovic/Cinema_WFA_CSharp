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
    public partial class FrmAddEditAsAdministrator : Form
    {
        private Administrator administrator;
        public FrmAddEditAsAdministrator(Administrator administrator)
        {
            this.administrator = administrator;
            InitializeComponent();
            DataElements.initializeLists();
            initializeCbMemberNames();
            //initializeProjections();
        }

        void initializeCbMemberNames()
        {
            foreach (Member member in DataElements.lstMbr)
            {
                cbMemberNames.Items.Add(member.FirstName + " " + member.LastName);
            }
        }

        private void cbMemberNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReservations.Items.Clear();
            if (cbMemberNames.SelectedItem != null)
            {
                foreach (Reservation reservation in DataElements.lstRsv)
                {
                    string firstName = cbMemberNames.SelectedItem.ToString().Split(' ')[0];
                    string lastName = cbMemberNames.SelectedItem.ToString().Split(' ')[1];

                    if (firstName.Equals(reservation.Member.FirstName) && lastName.Equals(reservation.Member.LastName))
                        cbReservations.Items.Add(reservation.UniId + ")" + "Movie Name : " + reservation.Projection.Movie.MovieName + ". Date and Time of Projection : "
                        + reservation.Projection.ProjectionDate.ToString("yyyy/MM/dd") + " -" + reservation.Projection.ProjectionStartTime +
                       ". Number Of Seats reserved : " + reservation.NumberOfSeats_reserved);
                }
            }
            tbMemberName.Text = cbMemberNames.SelectedItem.ToString();
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            if (cbReservations.SelectedItem != null)
            {
                Reservation reservation = (Reservation)DataElements.lstRsv.Where(r => r.UniId == Convert.ToInt32(cbReservations.SelectedItem.ToString().Split(')')[0])).FirstOrDefault();
                FrmEditReservationAsAdministrator frmEditReservation = new FrmEditReservationAsAdministrator(reservation);
                frmEditReservation.ShowDialog();

                if (frmEditReservation.DialogResult == DialogResult.OK)
                {
                    DataElements.initializeLists();
                }
            }
            else
                MessageBox.Show("You need to select a reservation first.");
        }

        private void btnEditProjections_Click(object sender, EventArgs e)
        {
            FrmProjectionsAdministration frmProjectionAdministration = new FrmProjectionsAdministration();
            frmProjectionAdministration.ShowDialog();
            if (frmProjectionAdministration.DialogResult == DialogResult.OK)
            {
                DataElements.initializeLists();
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (tbMemberName.Text != string.Empty)
            {
                string firstName = tbMemberName.Text.Split(' ')[0];
                string lastName = tbMemberName.Text.Split(' ')[1];
                Member member = (Member)DataElements.lstMbr.Where(m => m.FirstName == firstName && m.LastName == lastName).FirstOrDefault();
                if (member != null)
                {
                    cbMemberNames.Items.Remove(cbMemberNames.SelectedItem);
                    DataElements.lstMbr.Remove(member);
                    DbManagement.insert_update_delete("delete from Member1 where UniqueMemberId1=" + member.UniqueId);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditMovies_Click(object sender, EventArgs e)
        {
            FrmMovies frmMovies = new FrmMovies();
            frmMovies.ShowDialog();
            if (frmMovies.DialogResult == DialogResult.OK)
            {
                DataElements.initializeLists();
            }
        }
    }
}

