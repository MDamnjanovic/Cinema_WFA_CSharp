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
    public partial class FrmEditProjection : Form
    {
        private Projection projection;
        private bool invalidData;
        public FrmEditProjection(Projection projection)
        {
            this.projection = projection;
            InitializeComponent();
            DataElements.initializeLists();
            initializeData();
            initializeCbMovieNames();
            initializeCbTheaterId();
        }

        void initializeData ()
        {
            tbId.Text = projection.UniId.ToString();
            tbMovieName.Text = projection.Movie.MovieName;
            tbDate.Text = projection.ProjectionDate.ToString().Substring(0,9);
            tbTime.Text = projection.ProjectionStartTime;
            tbTheaterId.Text = projection.Theater.UniId.ToString();
            tbPrice.Text = projection.TicketPrice.ToString();
            dateTimePicker1.Value = DateTime.Now;
        }
        void initializeCbMovieNames ()
        {
            foreach (Movie movie in DataElements.lstMvs)
            {
                cbMovieNames.Items.Add(movie.MovieName);
            }
        }
        void initializeCbTheaterId()
        {
            foreach (Theater theater in DataElements.lstThtrs)
            {
                cbTheaterId.Items.Add(theater.UniId);
            }
        }

        private void cbMovieNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMovieName.Text = cbMovieNames.SelectedItem.ToString();
        }

        private void cbTheaterId_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTheaterId.Text = cbTheaterId.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Now)
                tbDate.Text = dateTimePicker1.Value.ToString().Substring(0, 9);
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                MessageBox.Show("You cannot select a date before today");
            }
        }

        bool timeCheck (string time)
        {
            DateTime result;
            if (DateTime.TryParse(time, out result))
                return true;
            else
                return false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string movieName = tbMovieName.Text;
            DateTime date = Convert.ToDateTime(tbDate.Text);
            string time = tbTime.Text;
            int theaterId = Convert.ToInt32(tbTheaterId.Text);
            double price = Convert.ToDouble(tbPrice.Text);
            if (timeCheck(time))
            {
                foreach (Projection p in DataElements.lstPrj)
                {
                    if (p.Theater.UniId == theaterId)
                    {
                        if (date == p.ProjectionDate && time == p.ProjectionStartTime)
                        {
                            MessageBox.Show("Theater you have selected is already booked with another projection. \nSelect different time or date.");
                            invalidData = true;
                            break;
                        }
                        else
                            invalidData = false;
                    }
                    else
                        invalidData = false;
                }
            }
            else
                MessageBox.Show("Inserted time was not in correct format.");
            if (!invalidData) 
            {
                Movie movie = (Movie)DataElements.lstMvs.Where(m => m.MovieName == movieName).FirstOrDefault();
                projection.Movie.MovieName = movieName;
                projection.ProjectionDate = date;
                projection.ProjectionStartTime = time;
                projection.Theater.UniId = theaterId;
                projection.TicketPrice = price;
                string sqlUpdate =
             "update Projection1 set UniqueTheaterId1='" + theaterId +
              "',UniqueMovieId1='" + movie.UniId +
              "',ProjectionDate='" + date +
              "',ProjectionStartTime='" + time +
              "',TicketPrice='" + price +
               "' where UniqueProjectionId1=" + projection.UniId;
                DbManagement.insert_update_delete(sqlUpdate);
                DialogResult = DialogResult.OK;
            } 
        }

    }
}
