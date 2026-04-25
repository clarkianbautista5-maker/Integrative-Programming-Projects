using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class Employee
    {
        private long employeeNumber;
        private string firstName;
        private string lastName;
        private string position;

        
        public long EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }
        public string FirstName
        {
           get { return firstName; }
           set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Employee()
        {
            this.employeeNumber = 0;
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.position = string.Empty;
        }
        public Employee(long employeeNumber, string firstName, string lastName, string position)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }


        


    }
}
