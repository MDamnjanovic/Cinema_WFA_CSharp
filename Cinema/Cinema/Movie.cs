using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Movie
    {
        int uniId;
        string movieName;
        string genre;
        int movieLength;
        int ageRestriction;

        public Movie(int uniId, string movieName, string genre, int movieLength, int ageRestriction)
        {
            this.UniId = uniId;
            this.MovieName = movieName;
            this.genre = genre;
            this.MovieLength = movieLength;
            this.AgeRestriction = ageRestriction;
        }

        public Movie (Movie movie)
        {
            this.UniId = movie.uniId;
            this.MovieName = movie.movieName;
            this.Genre = movie.genre;
            this.MovieLength = movie.movieLength;
            this.AgeRestriction = movie.ageRestriction;
        }
        public Movie() { }


        public int UniId { get => uniId; set => uniId = value; }
        public string MovieName { get => movieName; set => movieName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int MovieLength { get => movieLength; set => movieLength = value; }
        public int AgeRestriction { get => ageRestriction; set => ageRestriction = value; }
    }
}
