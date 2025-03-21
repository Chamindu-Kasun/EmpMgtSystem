using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceApplication
{
    public class Employee: User
    {

        // Constructor 
        public Employee(string username, string password, string role, string department, string contactNumber, string qualifications)
            // Call the base class constructor
            : base(username, password, role) 
        {
            Department = department;
            ContactNumber = contactNumber;
            Qualifications = qualifications;
        }

        public string Department { get; set; }
        public string ContactNumber { get; set; }
        public string Qualifications { get; set; }
    }
}