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
    public partial class FrmNewMovie : Form
    {
        public FrmNewMovie()
        {
            InitializeComponent();
            DataElements.initializeLists();
            tbId.Text = Convert.ToString(DataElements.lstMvs.Count + 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbId.Text);
            if (tbMovieName.Text != "" && tbGenre.Text != "" && tbMovieLength.Text != "" && tbAgeRestriction.Text != "")
            {
                int movieLength; int ageRestriction;
                if (Int32.TryParse(tbMovieLength.Text, out movieLength) && Int32.TryParse(tbAgeRestriction.Text, out ageRestriction))
                {
                    string movieName = tbMovieName.Text;
                    string genre = tbGenre.Text;
                    movieLength = Convert.ToInt32(tbMovieLength.Text);
                    ageRestriction = Convert.ToInt32(tbAgeRestriction.Text);
                    Movie newMovie = new Movie(id, movieName, genre, movieLength, ageRestriction);
                    DataElements.lstMvs.Add(newMovie);
                    string insertData = $"insert into Movie1(UniqueMovieId1,MovieName,Genre,MovieLength,AgeRestriction)"
                                    + $" values({id},'{movieName}','{genre}',{movieLength},{ageRestriction})";
                    DbManagement.insert_update_delete(insertData);
                    DialogResult = DialogResult.OK;
                }
                else
                { 
                    MessageBox.Show("Inserted incorrect data format for 'Movie Length' or 'Age Restriction'. \nTry again!");
                    tbMovieLength.Text = "";
                    tbAgeRestriction.Text = "";
                 }
            }
        }
    }
}
