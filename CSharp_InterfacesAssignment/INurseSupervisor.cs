using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    interface INurseSupervisor : IMedicalStaff
    {
        string NumberNursesSupervied { get; set; }
    }
}
