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
    public partial class FrmEditReservation : Form
    {
        private Reservation reservation;

        public FrmEditReservation(Reservation reservation)
        {
            this.reservation = reservation;
            InitializeComponent();
            DataElements.initializeLists();
            initializeReservationData();
        }

        void initializeReservationData ()
        {
            tbMovieName.Text = reservation.Projection.Movie.MovieName;
            tbDateTime.Text = reservation.Projection.ProjectionDate.ToString("yyyy/MM/dd") + 
                " " + reservation.Projection.ProjectionStartTime.ToString();
            NumberOfSeats.Value = reservation.NumberOfSeats_reserved;
            tbReservationBill.Text = Math.Round(reservation.ReservationBill).ToString() + " RSD";
        }
        int calculateAvailableSeats(Projection projection)
        {
            int availavbleSeats = projection.Theater.NumberOfSeats;
            foreach (Reservation res in DataElements.lstRsv)
            {
                if (res.Projection.UniId == projection.UniId)
                {
                    availavbleSeats = projection.Theater.NumberOfSeats - res.NumberOfSeats_reserved;
                }
            }

            return availavbleSeats;
        }

        private void NumberOfSeats_ValueChanged(object sender, EventArgs e)
        {
            int availableSeats = calculateAvailableSeats(reservation.Projection);
            if (availableSeats < 40)
                NumberOfSeats.Maximum = availableSeats / 6;
            else if (availableSeats < 10)
                NumberOfSeats.Maximum = availableSeats;
            else
                NumberOfSeats.Maximum = availableSeats / 7;

            int numberOfSeatsChanged = (int)NumberOfSeats.Value;
            double newReservationBill = (double)NumberOfSeats.Value * reservation.Projection.TicketPrice;
            tbReservationBill.Text = Convert.ToString(Math.Round(newReservationBill)) + " RSD";

        }

        private void tbReservationBill_TextChanged(object sender, EventArgs e)
        {
            //double newReservationBill = (double)NumberOfSeats.Value * reservation.Projection.TicketPrice;
            //tbReservationBill.Text = Convert.ToString(newReservationBill);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (NumberOfSeats.Value == 0)
            {
                DbManagement.insert_update_delete("delete from Reservation1 where UniqueReservationId1=" + reservation.UniId);
                DataElements.initializeLists();
                //MessageBox.Show("You cannot choose zero. \nIf you want to remove reservation, go to option 'remove'.");

            }
            else
            {
                Reservation res = (Reservation)DataElements.lstRsv.Where(r => r.UniId == reservation.UniId).FirstOrDefault();
                res.NumberOfSeats_reserved = (int)NumberOfSeats.Value;
                res.ReservationBill = Convert.ToDouble(tbReservationBill.Text.Split(' ')[0]);
                string sqlUpdate =
                 "update Reservation1 set UniqueProjectionId1='" + res.Projection.UniId +
                  "',UniqueMemberId1='" + res.Member.UniqueId +
                  "',NumberOfSeats='" + res.NumberOfSeats_reserved +
                  "',ReservationBill='" + res.ReservationBill +
                   "' where UniqueReservationId1=" + res.UniId;
                        DbManagement.insert_update_delete(sqlUpdate);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
