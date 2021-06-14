using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    interface IAttendee : IMedicalStaff
    {
        string Speciality { get; set; }
        string NumberResidentsSupervised { get; set; }
    }
}
