using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAutomation
{
    public class Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RepOfTurId{ get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public string Title { get; set; }
        public string PersonnelPic { get; set; }
        public object Tag { get; set; }
    }
}
