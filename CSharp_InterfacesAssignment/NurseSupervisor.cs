using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    public class NurseSupervisor : INurseSupervisor
    {
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string HireDate { get; set; }
        public string NumberNursesSupervied { get; set; }      					
    }
}
