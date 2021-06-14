using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InterfacesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This app demonstrates the use of Interfaces to put various types of medical staff into the same List<>
            //  and write them out to the Console with one loop on that list, while using multiple interface implementations
            //  to distinguish what type of staff each staff member is and write out any specific info. on that staff type

            List<IMedicalStaff> staffList = new List<IMedicalStaff>();

            CreateAttendees(ref staffList);
            CreateResidents(ref staffList);
            CreateNurseSupervisors(ref staffList);
            CreateRegisteredNurses(ref staffList);          
            CreateSurgicalTechnicians(ref staffList);

            foreach(IMedicalStaff staff in staffList)
            {
                //Standard fields for all staff
                Console.WriteLine($"Name: {staff.Name}");
                Console.WriteLine($"Employee ID: {staff.EmployeeId}");
                Console.WriteLine($"Start Date: {staff.HireDate}");

                //To get to the fields that are NOT common amongst all the staff types, I created new interfaces for
                //  each staff type (IAttendee, IResident, etc.) and had them implement : IMedicalStaff.
                //  Then in each of the regular class, I had them implement their own specific interface.
                //  For example, Resident.cs implements IResident, and IResident implements IMedicalStaff.
                //  This gives us the best of both words - we can pull common stuff from the IMedicalStaff, because my
                //  more specific interfaces implement it, AND we can get the staff-type-specific fields too, because
                //  our regular classes implement the specific interfaces that contain those fields.
                //  We can also use the "IS" command to see which staff type we're currently on, because of the way
                //  we've implemented the specific interfaces.

                if(staff is IResident resident)
                {
                    Console.WriteLine("Staff Type: Resident");
                    Console.WriteLine($"Supervising Attendee: {resident.SupervisingAttendee}");
                }

                if(staff is IAttendee attendee)
                {
                    Console.WriteLine("Staff Type: Attendee");
                    Console.WriteLine($"Speciality: {attendee.Speciality}");
                    Console.WriteLine($"Number of Residents Supervised: {attendee.NumberResidentsSupervised}");
                }

                if(staff is IRegisteredNurse registeredNurse)
                {
                    Console.WriteLine("Staff Type: Registered Nurse");
                    Console.WriteLine($"Supervising Nurse Supervisor: {registeredNurse.SupervisingNurseSupervisor}");
                }

                if(staff is INurseSupervisor nurseSupervisor)
                {
                    Console.WriteLine("Staff Type: Nurse Supervisor");
                    Console.WriteLine($"Number of Nurses Supervised: {nurseSupervisor.NumberNursesSupervied}");
                }

                if(staff is ISurgicalTechnician surgicalTechnician)
                {
                    Console.WriteLine("Staff Type: Surgical Technician");
                    Console.WriteLine($"Department: {surgicalTechnician.Department}");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }

        private static void CreateAttendees(ref List<IMedicalStaff> staffList)
        {
            Attendee attendee = new Attendee() { Name="Bob Smith", EmployeeId="1", HireDate="1/2/2020", NumberResidentsSupervised="10", Speciality="Pediatrics" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Bob Michaels", EmployeeId = "2", HireDate = "2/2/2020", NumberResidentsSupervised = "6", Speciality = "Cardiology" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Tom Johnson", EmployeeId = "3", HireDate = "3/2/1998", NumberResidentsSupervised = "10", Speciality = "Neuro" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Susan Jones", EmployeeId = "4", HireDate = "1/2/2021", NumberResidentsSupervised = "4", Speciality = "Pediatrics" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Jose Ramirez Smith", EmployeeId = "5", HireDate = "1/2/2020", NumberResidentsSupervised = "10", Speciality = "General Surgery" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Gennie Johnson", EmployeeId = "6", HireDate = "5/2/2020", NumberResidentsSupervised = "11", Speciality = "Pediatrics" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Ellie Raven", EmployeeId = "7", HireDate = "1/7/1999", NumberResidentsSupervised = "3", Speciality = "Emergency" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Lilith Fair", EmployeeId = "8", HireDate = "11/21/2020", NumberResidentsSupervised = "10", Speciality = "Pediatrics" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Mel Brooks", EmployeeId = "9", HireDate = "12/22/2019", NumberResidentsSupervised = "14", Speciality = "Plastics" };
            staffList.Add(attendee);
            attendee = new Attendee() { Name = "Raj Gupta", EmployeeId = "10", HireDate = "8/3/2020", NumberResidentsSupervised = "10", Speciality = "Pediatrics" };
            staffList.Add(attendee);
        }

        private static void CreateResidents(ref List<IMedicalStaff> staffList)
        {
            Resident resident = new Resident() { Name = "Conrad Hawkins", EmployeeId = "11", HireDate = "2/2/2017", SupervisingAttendee = "Bob Michaels" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Resey Dent", EmployeeId = "12", HireDate = "5/5/2018", SupervisingAttendee = "Raj Gupta" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Prakash Kumar", EmployeeId = "13", HireDate = "1/5/2018", SupervisingAttendee = "Bob Michaels" };
            staffList.Add(resident);
            resident = new Resident() { Name = "New Bee", EmployeeId = "14", HireDate = "5/5/2018", SupervisingAttendee = "Mel Brooks" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Kristen Conrad", EmployeeId = "15", HireDate = "5/2/2017", SupervisingAttendee = "Bob Michaels" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Forest Gump", EmployeeId = "16", HireDate = "3/1/2017", SupervisingAttendee = "Bob Michaels" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Rey Skywalker", EmployeeId = "17", HireDate = "5/5/2018", SupervisingAttendee = "Raj Gupta" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Ron Weasley", EmployeeId = "18", HireDate = "5/5/2018", SupervisingAttendee = "Lilith Fair" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Harry Potter", EmployeeId = "19", HireDate = "5/5/2018", SupervisingAttendee = "Lilith Fair" };
            staffList.Add(resident);
            resident = new Resident() { Name = "Hermione Granger", EmployeeId = "20", HireDate = "5/5/2018", SupervisingAttendee = "Lilith Fair" };
            staffList.Add(resident);
        }

        private static void CreateRegisteredNurses (ref List<IMedicalStaff> staffList)
        {
            RegisteredNurse rn = new RegisteredNurse() { Name = "Suba Kumar", EmployeeId = "21", HireDate = "4/13/2019", SupervisingNurseSupervisor="Jen Lopez" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Michael George", EmployeeId = "22", HireDate = "4/13/2019", SupervisingNurseSupervisor="Jen Lopez" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Ian McDonald", EmployeeId = "23", HireDate = "1/14/2019", SupervisingNurseSupervisor = "Jen Lopez" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Joe Joe", EmployeeId = "24", HireDate = "4/13/2019", SupervisingNurseSupervisor = "Jen Lopez" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Luke Skywalker", EmployeeId = "25", HireDate = "4/13/2019", SupervisingNurseSupervisor = "George Lucas" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Mandy Moore", EmployeeId = "26", HireDate = "7/12/2019", SupervisingNurseSupervisor = "Ben Aflec" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Kesha", EmployeeId = "27", HireDate = "1/11/2019", SupervisingNurseSupervisor = "Jen Lopez" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Michael Jordan", EmployeeId = "28", HireDate = "4/17/2019", SupervisingNurseSupervisor = "George Lucas" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Paul Jones", EmployeeId = "29", HireDate = "2/13/20201", SupervisingNurseSupervisor = "Jen Lopez" };
            staffList.Add(rn);
            rn = new RegisteredNurse() { Name = "Lilibeth Diana", EmployeeId = "30", HireDate = "4/13/2019", SupervisingNurseSupervisor = "Nurse Nevin" };
            staffList.Add(rn);
        }

        private static void CreateNurseSupervisors(ref List<IMedicalStaff> staffList)
        {
            NurseSupervisor nurseSupervisor = new NurseSupervisor() { Name = "Nurse Nevins", EmployeeId = "31", HireDate = "6/2/2017", NumberNursesSupervied="5" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Jen Lopez", EmployeeId = "32", HireDate = "2/10/2018", NumberNursesSupervied = "6" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Ben Aflec", EmployeeId = "33", HireDate = "1/11/2017", NumberNursesSupervied = "3" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "George Lucas", EmployeeId = "34", HireDate = "2/10/2015", NumberNursesSupervied = "6" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Megan Markle", EmployeeId = "35", HireDate = "2/10/2018", NumberNursesSupervied = "3" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Queen Victoria", EmployeeId = "36", HireDate = "2/4/2018", NumberNursesSupervied = "6" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Jar Jar Binks", EmployeeId = "37", HireDate = "5/15/2018", NumberNursesSupervied = "4" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Obi-wan Kenobi", EmployeeId = "38", HireDate = "2/10/2018", NumberNursesSupervied = "6" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Anakin Skywalker", EmployeeId = "39", HireDate = "2/19/2016", NumberNursesSupervied = "6" };
            staffList.Add(nurseSupervisor);
            nurseSupervisor = new NurseSupervisor() { Name = "Billy DaKid", EmployeeId = "40", HireDate = "2/10/2018", NumberNursesSupervied = "2" };
        }

        private static void CreateSurgicalTechnicians(ref List<IMedicalStaff> staffList)
        {
            SurgicalTechnician surgicalTechnician = new SurgicalTechnician() { Name = "Suzanne Reese", EmployeeId = "41", HireDate = "4/4/2014", Department = "Neuro" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Bhaskar Jeyakumar", EmployeeId = "42", HireDate = "1/14/2021", Department = "Cardiology" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Madonna", EmployeeId = "43", HireDate = "1/14/2010", Department = "Pediatrics" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Jay Z", EmployeeId = "44", HireDate = "1/11/2021", Department = "Cardiology" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Koby Bryant", EmployeeId = "45", HireDate = "1/14/2021", Department = "Neuro" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Michael Stopher", EmployeeId = "46", HireDate = "2/14/2010", Department = "Emergency" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Portia LaGrasse", EmployeeId = "47", HireDate = "1/15/2021", Department = "Cardiology" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Big Ed", EmployeeId = "48", HireDate = "1/15/2016", Department = "Neuro" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Jim Kristofferson", EmployeeId = "49", HireDate = "2/15/2013", Department = "Pediatrics" };
            surgicalTechnician = new SurgicalTechnician() { Name = "Elizabeth Olson", EmployeeId = "50", HireDate = "2/15/2011", Department = "Pediatrics" };

        }
    }
}
