using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAutomation
{
    public enum Title
    {
        [Display(Name = "Manager")]
        Manager,
        [Display(Name = "Executive")] 
        Executive,
        [Display(Name = "CEO")] 
        CEO,
        [Display(Name = "Cleaning Staff")] 
        CleaningStaff,
        [Display(Name = "Consultant")] 
        Consultant,
        [Display(Name = "Customer Representative")] 
        CustomerRepresentative,
        [Display(Name = "Instructor")] 
        Instructor,
        Unspecified
    }
}
