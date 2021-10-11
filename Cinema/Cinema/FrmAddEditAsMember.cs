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
    public partial class FrmAddEditAsMember : Form
    {
        private Member member;
        public FrmAddEditAsMember(Member member)
        {
            this.member = member;
            InitializeComponent();
            DataElements.initializeLists();
            initializeReservations();
            initializeMemberData();


        }

        void initializeReservations ()
        {
            lbReservations.Items.Clear();
            foreach(Reservation res in DataElements.lstRsv)
            {
                if(res.Member.UniqueId == member.UniqueId)
                {
                    res.ReservationDisplay += res.Projection.Movie.MovieName + " " + res.Projection.Movie.MovieLength + " minutes " +
                    "Bill price: " + res.ReservationBill + "RSD " + "Date and time: " + res.Projection.ProjectionDate.ToString("yyyy/MM/dd") + 
                    " " + res.Projection.ProjectionStartTime + " Reserved seats: " + res.NumberOfSeats_reserved;
                    lbReservations.Items.Add(res.ReservationDisplay);
                    //member.LstRes_PerMember.Add(res);
                }
            }
        }
        void initializeMemberData ()
        {
            tbMemberName.Text = member.FirstName + " " + member.LastName;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbReservations.SelectedItem != null)
            {
                Reservation reserv = (Reservation)DataElements.lstRsv.Where(r => r.ReservationDisplay == lbReservations.SelectedItem.ToString()).FirstOrDefault();
                DataElements.lstRsv.Remove(reserv);
                DbManagement.insert_update_delete("delete from Reservation1 where UniqueReservationId1=" + reserv.UniId);
                lbReservations.Items.Remove(lbReservations.SelectedItem);

            }
            else
                MessageBox.Show("You need to select a reservation first.");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbReservations.SelectedItem != null)
            {
                Reservation reservation = (Reservation)DataElements.lstRsv.Where(r => r.ReservationDisplay == lbReservations.SelectedItem.ToString()).FirstOrDefault();

                FrmEditReservation frmEditRes = new FrmEditReservation(reservation);
                frmEditRes.ShowDialog();

                if (frmEditRes.DialogResult == DialogResult.OK)
                {
                    initializeReservations();
                }
            }
            else
                MessageBox.Show("You need to select a reservation first.");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            FrmNewReservation frmNewRes = new FrmNewReservation(member);
            frmNewRes.ShowDialog();
            if (frmNewRes.DialogResult == DialogResult.OK)
            {
                initializeReservations();
            }
        }
    }
}
