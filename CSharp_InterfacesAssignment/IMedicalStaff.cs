using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    interface IMedicalStaff
    {
        string Name { get; set; }
        string EmployeeId { get; set; }
        string HireDate { get; set; }
    }
}
