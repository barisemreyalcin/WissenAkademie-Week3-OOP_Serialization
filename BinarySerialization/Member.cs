using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    [Serializable]
    public class Member
    {
        public Guid MemberId { get; set; } // Guid bir unique veri tipi
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //System.Runtime.Serialization 

        public override string ToString()
        {
            StringBuilder strMember = new StringBuilder();
            strMember.Append(
                $"Member Id: {this.MemberId}\n" +
                $"Member Full Name: {this.FirstName} {this.LastName}\n" +
                $"Member Age: {this.Age}"
            );
            return strMember.ToString();
        }
    }
}
