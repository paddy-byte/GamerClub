using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamersClub
{
    public class Member
    {
        public string name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime dateJoined { get; set; }
        public string gender { get; set; }
        public int rank { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string favouriteGenre { get; set; }

        public Member() { }

        public Member(string name, DateTime dOB, DateTime dateJoined, string gender, int rank, string address, string email, string favouriteGenre)
        {
            this.name = name;
            this.DOB = dOB;
            this.dateJoined = dateJoined;
            this.gender = gender;
            this.rank = rank;
            this.address = address;
            this.email = email;
            this.favouriteGenre = favouriteGenre;
        }
    }
}
