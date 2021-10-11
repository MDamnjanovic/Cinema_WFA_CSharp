using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Reservation
    {
        int uniId;
        Projection projection;
        Member member;
        int numberOfSeats_reserved;
        double reservationBill;


        public Reservation(int uniId, Projection projection, Member member, int numberOfSeats_reserved, double reservationBill)
        {
            this.UniId = uniId;
            this.Projection = projection;
            this.Member = member;
            this.NumberOfSeats_reserved = numberOfSeats_reserved;
            this.ReservationBill = reservationBill;
        }
        public Reservation (Reservation reservation)
        {
            this.UniId = reservation.uniId;
            this.Projection = projection;
            this.Member = member;
            this.NumberOfSeats_reserved = numberOfSeats_reserved;
            this.ReservationBill = reservationBill;
        }

        string reservationDisplay = "";

        public int UniId { get => uniId; set => uniId = value; }
        public Projection Projection { get => projection; set => projection = value; }
        public Member Member { get => member; set => member = value; }
        public int NumberOfSeats_reserved { get => numberOfSeats_reserved; set => numberOfSeats_reserved = value; }
        public double ReservationBill { get => reservationBill; set => reservationBill = value; }
        public string ReservationDisplay { get => reservationDisplay; set => reservationDisplay = value; }
    }
}
