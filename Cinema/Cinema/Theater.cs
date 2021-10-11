using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Theater
    {
        int uniId;
        int theaterNumber;
        int numberOfSeats;

        public Theater(int uniId, int theaterNumber, int numberOfSeats)
        {
            this.UniId = uniId;
            this.TheaterNumber = theaterNumber;
            this.NumberOfSeats = numberOfSeats;
        }
        public Theater(Theater theater)
        {
            this.UniId = theater.uniId;
            this.TheaterNumber = theater.theaterNumber;
            this.NumberOfSeats = theater.numberOfSeats;
        }


        public int UniId { get => uniId; set => uniId = value; }
        public int TheaterNumber { get => theaterNumber; set => theaterNumber = value; }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
}
