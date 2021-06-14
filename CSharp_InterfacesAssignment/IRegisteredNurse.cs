using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    interface IRegisteredNurse : IMedicalStaff
    {
        string SupervisingNurseSupervisor { get; set; }
    }
}
