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
    public partial class FrmNewProjection : Form
    {
        private bool invalidData=false;

        public FrmNewProjection()
        {
            InitializeComponent();
            DataElements.initializeLists();
            initializeCbMovieNames();
            initializeCbTheaterId();
            initializeData();

        }

        void initializeData ()
        {
            tbId.Text = (DataElements.lstPrj.Count + 1).ToString();
            dateTimePicker1.Value = DateTime.Now;
        }
        void initializeCbMovieNames()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewProjection_Click(object sender, EventArgs e)
        {
            if (cbMovieNames.SelectedItem != null)
            {
                if (cbTheaterId.SelectedItem != null)
                {
                    int theaterId = Convert.ToInt32(cbTheaterId.SelectedItem.ToString());
                    string date = dateTimePicker1.Value.ToString().Substring(0, 9);
                    DateTime date1 = Convert.ToDateTime(date);
                    string time = tbTime.Text;
                    foreach (Projection p in DataElements.lstPrj)
                    {

                        if (p.Theater.UniId == theaterId)
                        {
                            if (date1 == p.ProjectionDate && time == p.ProjectionStartTime)
                            {
                                MessageBox.Show("Theater you have selected is already booked with another projection. \nSelect different time or date.");
                                invalidData = true;
                                break;
                            }
                            
                        }
                      
                    }
                    if (!invalidData)
                    {
                        DateTime timeResult;
                        if (DateTime.TryParse(time, out timeResult))
                        {
                            int numOfSeats = 0;
                            int projectionId = Convert.ToInt32(tbId.Text);
                            string movieName = cbMovieNames.SelectedItem.ToString();
                            double price = Convert.ToDouble(tbPrice.Text);
                            Theater theater = (Theater)DataElements.lstThtrs.Where(t => t.UniId == theaterId).FirstOrDefault();
                            Movie movie = (Movie)DataElements.lstMvs.Where(m => m.MovieName == movieName).FirstOrDefault();
                            Projection newProjection = new Projection(projectionId, date1, price, time, theater, movie);
                            DataElements.lstPrj.Add(newProjection);
                            string insertData = $"insert into Projection1(UniqueProjectionId1,ProjectionDate,TicketPrice,ProjectionStartTime,UniqueTheaterId1,UniqueMovieId1,NumOfSeats)"
                                + $" values({projectionId},'{date1}',{price},'{time}',{theaterId},{movie.UniId},{numOfSeats})";
                            DbManagement.insert_update_delete(insertData);
                            DialogResult = DialogResult.OK;

                        }
                    }

                }
                else
                    MessageBox.Show("You need to select a Theater first.");


            }
            else
                MessageBox.Show("You need to select a Movie first.");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Now)
            {
                dateTimePicker1.Value.ToString().Substring(0, 9);
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                MessageBox.Show("You cannot select a date before today");
            }
        }
    }
}
