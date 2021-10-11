using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class DataElements
    {
        public static List<Member> lstMbr = new List<Member>();
        public static List<Administrator> lstAdm = new List<Administrator>();
        public static List<Movie> lstMvs = new List<Movie>();
        public static List<Theater> lstThtrs = new List<Theater>();
        public static List<Projection> lstPrj = new List<Projection>();
        public static List<Reservation> lstRsv = new List<Reservation>();


        public static void initializeLists()
        {
            lstMbr.Clear();
            lstAdm.Clear();
            lstMvs.Clear();
            lstThtrs.Clear();
            lstPrj.Clear();
            lstRsv.Clear();

            lstMbr = DbManagement.readMembers();
            lstAdm = DbManagement.readAdministrators();
            lstMvs = DbManagement.readMovies();
            lstThtrs = DbManagement.readTheaters();
            lstPrj = DbManagement.readProjections();
            lstRsv = DbManagement.readReservations();

            initialize_Member_Rsv();
        }

        static void initialize_Member_Rsv()
        {
            foreach (Reservation res in lstRsv)
            {
                foreach (Member member in lstMbr)
                {
                    if (res.Member.UniqueId == member.UniqueId)
                    {
                        member.LstRes_PerMember.Add(res);
                    }
                }
            }
        }

    }
}
