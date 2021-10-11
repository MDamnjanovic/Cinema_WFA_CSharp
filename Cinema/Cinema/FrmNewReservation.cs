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
    public partial class FrmNewReservation : Form
    {
        private Member member;
        DateTime dateFrom;
        DateTime dateTo;
        public FrmNewReservation(Member member)
        {
            this.member = member;
            InitializeComponent();
            DataElements.initializeLists();
            initializeCbTheaters();
            initializeCbMovieNames();
            initializeDTPickers();
        }

        void initializeDTPickers()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(30);
            dateFrom = dateTimePicker1.Value;
            dateTo = dateTimePicker2.Value;
        }

        void initializeCbTheaters ()
        {
            foreach (Theater theater in DataElements.lstThtrs)
            {
                cbTheaters.Items.Add(theater.TheaterNumber);
            }
            if (cbTheaters.Items.Count > 0)
                cbTheaters.SelectedIndex = 0;
        }
        void initializeCbMovieNames ()
        {
            int uniId = DataElements.lstMvs.Count;
            string movieName = string.Empty; string genre = string.Empty; int movieLength = 0; int ageRestriction = 0;
            Movie movieDisplays = new Movie(uniId, movieName, genre, movieLength, ageRestriction);

            cbMovieNames.Items.Add(movieDisplays.MovieName);

            foreach (Movie movie in DataElements.lstMvs)
            {
                cbMovieNames.Items.Add(movie.MovieName);
            }
            if (cbMovieNames.Items.Count > 0)
                cbMovieNames.SelectedItem = 0;
        }

        private void btnShowProjections_Click(object sender, EventArgs e)
        {
            lbAvailableProjections.Items.Clear();
            foreach (Projection projection in DataElements.lstPrj)
            {
                if (dateTimePicker1.Value < projection.ProjectionDate && projection.ProjectionDate < dateTimePicker2.Value)
                {
                    //if (projection.Theater.TheaterNumber == Convert.ToInt32(cbTheaters.SelectedItem));
                    //{
                        if (projection.Movie.MovieName.Equals(cbMovieNames.SelectedItem))
                         {
                            projection.ProjectionDisplay = projection.Movie.MovieName + " " + projection.Movie.MovieLength + " minutes. " +
                            Convert.ToInt32(projection.TicketPrice) + " RSD. " + projection.ProjectionDate.ToString("yyyy/MM/dd") + " -" + projection.ProjectionStartTime + ". Theater " +
                            projection.Theater.TheaterNumber + ". Number Of Available Seats : " + calculateAvailableSeats(projection) + ".";
                            lbAvailableProjections.Items.Add(projection.ProjectionDisplay);
                        NumOfSeats.Maximum = calculateAvailableSeats(projection) / 8;
                        
                         }
                        if (cbMovieNames.SelectedItem == null || cbMovieNames.SelectedItem.ToString() == "")
                         {
                            projection.ProjectionDisplay = projection.Movie.MovieName + " " + projection.Movie.MovieLength + " minutes. " +
                            Convert.ToInt32(projection.TicketPrice) + " RSD. " + projection.ProjectionDate.ToString("yyyy/MM/dd") + " -" + projection.ProjectionStartTime + ". Theater " +
                            projection.Theater.TheaterNumber + ". Number Of Available Seats : " + calculateAvailableSeats(projection) + ".";
                            lbAvailableProjections.Items.Add(projection.ProjectionDisplay);

                    }
                    //}
                }
            }
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

        private void dateTimePicker1_CloseUp(object sender, EventArgs e) // petak 10 30
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Date 'from' cannot be after date 'to'.");
                dateTimePicker1.Value = dateFrom;
            }
            else if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Date 'from' cannot be before today.");
                dateTimePicker1.Value = dateFrom;
            }
            else
                dateFrom = dateTimePicker1.Value;
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Date 'to' cannot be before date 'from'.");
                dateTimePicker2.Value = dateTo;
            }
            else
                dateTo = dateTimePicker2.Value;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbAvailableProjections_SelectedIndexChanged(object sender, EventArgs e)
        {
            Projection proj = (Projection)DataElements.lstPrj.Where(pr => pr.ProjectionDisplay == lbAvailableProjections.Items[lbAvailableProjections.SelectedIndex].ToString()).FirstOrDefault();
            if (calculateAvailableSeats(proj) < 40)
                NumOfSeats.Maximum = calculateAvailableSeats(proj) / 6;
            else if (calculateAvailableSeats(proj) < 10)
                NumOfSeats.Maximum = calculateAvailableSeats(proj);
            else
                NumOfSeats.Maximum = calculateAvailableSeats(proj) / 7;
            if (calculateAvailableSeats(proj) == 0)
                NumOfSeats.Value = 0;
            tbTotalPrice.Text = Convert.ToString(Math.Round(proj.TicketPrice * (double)NumOfSeats.Value)) + " RSD";

        }

        private void NumOfSeats_ValueChanged(object sender, EventArgs e)
        {
            if (lbAvailableProjections.SelectedItem != null)
            {
                Projection proj = (Projection)DataElements.lstPrj.Where(pr => pr.ProjectionDisplay == lbAvailableProjections.SelectedItem.ToString()).FirstOrDefault();
                if (calculateAvailableSeats(proj) < 40)
                    NumOfSeats.Maximum = calculateAvailableSeats(proj) / 6;
                else if (calculateAvailableSeats(proj) < 10)
                    NumOfSeats.Maximum = calculateAvailableSeats(proj);
                else
                    NumOfSeats.Maximum = calculateAvailableSeats(proj) / 7;
                if (calculateAvailableSeats(proj) == 0)

                NumOfSeats.Value = 0;
                int seats = (int)NumOfSeats.Value;
                double totalPrice = proj.TicketPrice * seats;
                tbTotalPrice.Text = Convert.ToString(Math.Round(totalPrice)) + " RSD";
            }
        }
        

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            if (lbAvailableProjections.SelectedItem != null)
            {
                Projection proj = (Projection)DataElements.lstPrj.Where(pr => pr.ProjectionDisplay == lbAvailableProjections.SelectedItem.ToString()).FirstOrDefault();
                if ( member.getMemberAge(member.BirthDate) > proj.Movie.AgeRestriction)
                {
                    int numberOfSeatsReserved = (int)NumOfSeats.Value;
                    double reservationBill = Convert.ToDouble(tbTotalPrice.Text.Split(' ')[0]);
                    int uniqueId = DataElements.lstRsv.Count + 1;
                    Reservation newReservation = new Reservation(uniqueId, proj, member, numberOfSeatsReserved, reservationBill);
                    DataElements.lstRsv.Add(newReservation);
                    string insertData = $"insert into Reservation1(UniqueReservationId1, UniqueProjectionId1, UniqueMemberId1, NumberOfSeats, ReservationBill)" + $" values({uniqueId}, {proj.UniId}, {member.UniqueId}, {numberOfSeatsReserved}, {reservationBill})";
                    DbManagement.insert_update_delete(insertData);
                    MessageBox.Show("Reservation confirmed!");

                    //string update = "update Projection1 set NumOfSeats=NumOfSeats-" + numberOfSeatsReserved +
                    //                " where UniqueProjectionId1=" + proj.UniId;
                    //DbManagement.insert_update_delete(update);

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Sorry, due to age restriction you cannot book this movie! \nPlease try another one!");


            }
            else
                MessageBox.Show("You have not selected a projection. \nAfter You select one, please check how many seats you wish to reserve.");
        }
    }
}
