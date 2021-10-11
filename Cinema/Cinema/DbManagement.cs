using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public class DbManagement
    {
        //public static string connString = "Server=DESKTOP-13T8DLV\\SQLEXPRESS; Database=cinema; Integrated Security=True;";

        public static string connString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\damnj\source\repos\Cinema\Cinema\Cinemadb.mdf;Integrated Security = True";

        public static void insert_update_delete(string sqlModify)
        {

            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlModify, conn);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }


        }


        public static List<Member> readMembers()
        {

            List<Member> lstMembers = new List<Member>();
           // List<Reservation> lstRes = readReservations();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Member1", conn);
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int uniqueId = Convert.ToInt32(sqlDataReader.GetValue(0));
                string firstName = sqlDataReader.GetValue(1).ToString();
                string lastName = sqlDataReader.GetValue(2).ToString();
                DateTime birthDate = Convert.ToDateTime(sqlDataReader.GetValue(3));
                string contactNumber = sqlDataReader.GetValue(4).ToString();
                string sex = sqlDataReader.GetValue(5).ToString();
                string emailAddress = sqlDataReader.GetValue(6).ToString();
                string password = sqlDataReader.GetValue(7).ToString();
                Member member = new Member(uniqueId, firstName, lastName, birthDate, contactNumber, sex, emailAddress, password);

                //foreach(Reservation reservation in lstRes)
                //{
                //    if (reservation.Member.UniqueId == member.UniqueId)
                //    {
                //        member.LstRes_PerMember.Add(reservation);
                //    }
                //}

                lstMembers.Add(member);
            }

            sqlDataReader.Close();
            sqlCmd.Dispose();
            conn.Close();

            return lstMembers;

        }

        public static List<Administrator> readAdministrators()
        {

            List<Administrator> lstAdministrators = new List<Administrator>();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Administrator1", conn);
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int uniqueId = Convert.ToInt32(sqlDataReader.GetValue(0));
                string firstName = sqlDataReader.GetValue(1).ToString();
                string lastName = sqlDataReader.GetValue(2).ToString();
                DateTime birthDate = Convert.ToDateTime(sqlDataReader.GetValue(3));
                string contactNumber = sqlDataReader.GetValue(4).ToString();
                string sex = sqlDataReader.GetValue(5).ToString();
                string emailAddress = sqlDataReader.GetValue(6).ToString();
                string password = sqlDataReader.GetValue(7).ToString();
                Administrator admin = new Administrator(uniqueId, firstName, lastName, birthDate, contactNumber, sex, emailAddress, password);
                lstAdministrators.Add(admin);
            }

            sqlDataReader.Close();
            sqlCmd.Dispose();
            conn.Close();

            return lstAdministrators;

        }



        public static List<Movie> readMovies()
        {

            List<Movie> lstMovies = new List<Movie>();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Movie1", conn); 
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader(); 
            while (sqlDataReader.Read())
            {
                int uniId = Convert.ToInt32(sqlDataReader.GetValue(0));
                string movieName = sqlDataReader.GetValue(1).ToString();
                string genre = sqlDataReader.GetValue(2).ToString();
                int movieLength = Convert.ToInt32(sqlDataReader.GetValue(3));
                int ageRestriction = Convert.ToInt32(sqlDataReader.GetValue(4));
                Movie movie = new Movie(uniId, movieName, genre, movieLength, ageRestriction);
                lstMovies.Add(movie);
            }

            sqlDataReader.Close();
            sqlCmd.Dispose();
            conn.Close();

            return lstMovies;

        }

        public static List<Theater> readTheaters()
        {

            List<Theater> lstTheaters = new List<Theater>();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Theater1", conn); 
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader(); 
            while (sqlDataReader.Read())
            {
                int uniId = Convert.ToInt32(sqlDataReader.GetValue(0));
                int theaterNumber = Convert.ToInt32(sqlDataReader.GetValue(1));
                int numberOfSeats = Convert.ToInt32(sqlDataReader.GetValue(2));
                Theater theater = new Theater(uniId, theaterNumber, numberOfSeats);
                lstTheaters.Add(theater);
            }

            sqlDataReader.Close();
            sqlCmd.Dispose();
            conn.Close();

            return lstTheaters;

        }
        public static List<Projection> readProjections()
        {

            List<Projection> lstProjections = new List<Projection>();
            List<Theater> lstTheaters = readTheaters();
            List<Movie> lstMovies = readMovies();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Projection1", conn); 
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader(); 
            while (sqlDataReader.Read())
            {
                int uniId = Convert.ToInt32(sqlDataReader.GetValue(0));
                DateTime projectionDate = Convert.ToDateTime(sqlDataReader.GetValue(1));
                double ticketPrice = Convert.ToDouble(sqlDataReader.GetValue(2));
                string projectionStartTime = (sqlDataReader.GetValue(3)).ToString();
                int theaterId = Convert.ToInt32(sqlDataReader.GetValue(4));
                Theater Theater_byId = (Theater)DataElements.lstThtrs.Where(th => th.UniId == theaterId).FirstOrDefault();
                Theater theater = new Theater(Theater_byId);
                int movieId = Convert.ToInt32(sqlDataReader.GetValue(5));
                Movie movie_byId = (Movie)DataElements.lstMvs.Where(mv => mv.UniId == movieId).FirstOrDefault();
                Movie movie = new Movie(movie_byId);
                Projection projection = new Projection (uniId, projectionDate, ticketPrice, projectionStartTime, theater, movie);
                lstProjections.Add(projection);
            }

            sqlDataReader.Close();
            sqlCmd.Dispose();
            conn.Close();

            return lstProjections;

        }

        public static List<Reservation> readReservations()
        {

            List<Reservation> lstReservations = new List<Reservation>();
            List<Projection> lstProjections = readProjections();
            List<Member> lstMembers = readMembers();

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Reservation1", conn);
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int uniId = Convert.ToInt32(sqlDataReader.GetValue(0));
                int projectionId = Convert.ToInt32(sqlDataReader.GetValue(1));
                Projection projection_byId = (Projection)DataElements.lstPrj.Where(pr => pr.UniId == projectionId).FirstOrDefault();
                Projection projection = new Projection(projection_byId);
                int memberId = Convert.ToInt32(sqlDataReader.GetValue(2));
                Member member_byId = (Member)DataElements.lstMbr.Where(mb => mb.UniqueId == memberId).FirstOrDefault();
                Member member = new Member(member_byId);                
                int numberOfSeats_reserved = Convert.ToInt32(sqlDataReader.GetValue(3));
                double reservationBill = Convert.ToDouble(sqlDataReader.GetValue(4));
                Reservation reservation = new Reservation(uniId, projection, member, numberOfSeats_reserved, reservationBill);
                lstReservations.Add(reservation);
            }


            sqlDataReader.Close();
            sqlCmd.Dispose();
            conn.Close();

            return lstReservations;

        }




    }
}
