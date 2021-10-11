using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Projection
    {
        int uniId;
        DateTime projectionDate;
        Theater theater;
        double ticketPrice;
        string projectionStartTime;
        Movie movie;

        public Projection(int uniId, DateTime projectionDate, double ticketPrice, string projectionStartTime,Theater theater, Movie movie)
        {
            this.UniId = uniId;
            this.ProjectionDate = projectionDate;
            this.Theater = theater;
            this.TicketPrice = ticketPrice;
            this.ProjectionStartTime = projectionStartTime;
            this.Movie = movie;
        }

        public Projection (Projection projection)
        {
            this.UniId = projection.uniId;
            this.ProjectionDate = projection.projectionDate;
            this.Theater = projection.theater;
            this.TicketPrice = projection.ticketPrice;
            this.ProjectionStartTime = projection.projectionStartTime;
            this.Movie = projection.movie;
        }
        string projectionDisplay = "";

        public int UniId { get => uniId; set => uniId = value; }
        public DateTime ProjectionDate { get => projectionDate; set => projectionDate = value; }
        public Theater Theater { get => theater; set => theater = value; }
        public double TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        public string ProjectionStartTime { get => projectionStartTime; set => projectionStartTime = value; }
        public Movie Movie { get => movie; set => movie = value; }
        public string ProjectionDisplay { get => projectionDisplay; set => projectionDisplay = value; }
    }
}
