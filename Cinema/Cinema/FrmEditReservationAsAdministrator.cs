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
    public partial class FrmEditReservationAsAdministrator : Form
    {
        private Reservation reservation;

        public FrmEditReservationAsAdministrator(Reservation reservation)
        {
            this.reservation = reservation;
            InitializeComponent();
            DataElements.initializeLists();
            initializeCbMovieNames();
            cbMovieNames.Text = reservation.Projection.Movie.MovieName;
            cbProjections.Text = reservation.Projection.ProjectionDate.ToString("yyyy/MM/dd") +
            " " + reservation.Projection.ProjectionStartTime.ToString();
            NumberOfSeats.Value = reservation.NumberOfSeats_reserved;
            tbReservationBill.Text = Math.Round(reservation.ReservationBill).ToString() + " RSD";

        }
        void initializeCbMovieNames ()
        {
            foreach (Movie movie in DataElements.lstMvs)
            {
                cbMovieNames.Items.Add(movie.MovieName);
            }
        }
        

        private void cbMovieNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)DataElements.lstMvs.Where(m => m.MovieName == cbMovieNames.SelectedItem.ToString()).FirstOrDefault();
            cbProjections.Items.Clear();
            foreach (Projection p in DataElements.lstPrj)
            {
                if (movie.MovieName == p.Movie.MovieName)
                {
                    cbProjections.Items.Add(p.ProjectionDate.ToString("yyyy/MM/dd") +
                    " " + p.ProjectionStartTime.ToString());
                    NumberOfSeats.Value = 0;
                    tbReservationBill.Text = string.Empty;
                }
            }
        }

        private void cbProjections_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Projection projection = (Projection)DataElements.lstPrj.Where(pr => (pr.ProjectionDate + " " + pr.ProjectionStartTime) == cbProjections.SelectedItem.ToString()).FirstOrDefault();
            //if (projection != null)
            //{
            //    NumberOfSeats.Value = 1;
            //    tbReservationBill.Text = Math.Round(projection.TicketPrice).ToString() + " RSD";
            //}
        }

        private void NumberOfSeats_ValueChanged(object sender, EventArgs e)
        { 
            int numberOfSeatsChanged = (int)NumberOfSeats.Value;
            double newReservationBill = (double)NumberOfSeats.Value * reservation.Projection.TicketPrice;
            tbReservationBill.Text = Convert.ToString(Math.Round(newReservationBill)) + " RSD";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            reservation.Projection.Movie.MovieName = cbMovieNames.SelectedItem.ToString();
            reservation.Projection.ProjectionDate = Convert.ToDateTime(cbProjections.SelectedItem.ToString().Split(' ')[0]);
            reservation.Projection.ProjectionStartTime = cbProjections.SelectedItem.ToString().Split(' ')[1];
            Projection projection = (Projection)DataElements.lstPrj.Where(pr => (pr.ProjectionDate == reservation.Projection.ProjectionDate && pr.ProjectionStartTime ==
            reservation.Projection.ProjectionStartTime)).FirstOrDefault();
            reservation.NumberOfSeats_reserved = (int)NumberOfSeats.Value;
            reservation.ReservationBill = Convert.ToDouble(tbReservationBill.Text.Split(' ')[0]);
            if (reservation.NumberOfSeats_reserved != 0)
            {
                string sqlUpdate =
                     "update Reservation1 set UniqueProjectionId1='" + projection.UniId +
                      "',NumberOfSeats='" + reservation.NumberOfSeats_reserved +
                      "',ReservationBill='" + reservation.ReservationBill +
                       "' where UniqueReservationId1=" + reservation.UniId;
                DbManagement.insert_update_delete(sqlUpdate);
                //string updateSql =
                //    "update Projection1 set NumOfSeats=NumOfSeats-" + reservation.NumberOfSeats_reserved +
                //    " where UniqueProjectionId1=" + projection.UniId;
                //DbManagement.insert_update_delete(updateSql);
            }
            else
                DbManagement.insert_update_delete("delete from Reservation1 where UniqueReservationId1=" + reservation.UniId);

            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
