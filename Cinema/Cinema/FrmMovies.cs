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
    public partial class FrmMovies : Form
    {
        public FrmMovies()
        {
            InitializeComponent();
            DataElements.initializeLists();
            initializeMovieNames();
        }
        void initializeMovieNames ()
        {
            lbMovieNames.Items.Clear(); 

            foreach (Movie movie in DataElements.lstMvs)
            {
                lbMovieNames.Items.Add(movie.MovieName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbMovieNames.SelectedItem != null)
            {
                string movieName = lbMovieNames.SelectedItem.ToString();
                Movie movie = (Movie)DataElements.lstMvs.Where(m => m.MovieName == movieName).FirstOrDefault();
                if (movie != null)
                {
                    lbMovieNames.Items.Remove(lbMovieNames.SelectedItem);
                    DataElements.lstMvs.Remove(movie);
                    DbManagement.insert_update_delete("delete from Movie1 where UniqueMovieId1=" + movie.UniId);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNewMovie frmNewMovie = new FrmNewMovie();
            frmNewMovie.ShowDialog();
            if (frmNewMovie.DialogResult == DialogResult.OK)
            {
                initializeMovieNames();
            }
        }
    }
}
