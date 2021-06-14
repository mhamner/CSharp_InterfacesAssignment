using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    public class Attendee : IAttendee
    {
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string HireDate { get; set; }
        public string Speciality { get; set; }
        public string NumberResidentsSupervised { get; set; }     			
    }
}
