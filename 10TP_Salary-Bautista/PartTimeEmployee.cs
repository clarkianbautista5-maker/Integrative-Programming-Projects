using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10TP_Payroll_Bautista;

namespace PayrollNamespace
{
    public class PartTimeEmployee : Employee, IEmployee
    { 
        private string fName;
        private string lName;
        private string department;
        private string jobTitle;
        private double Salary;
        private double ratePerHour;
        private int hoursWorked;
        
        
        

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public double BasicSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            Salary = hoursWorked * ratePerHour;
        }
        public PartTimeEmployee(string name, double ratePerHour, int hoursWorked)
            : base(name)
        {
            this.ratePerHour = ratePerHour;
            this.hoursWorked = hoursWorked;
            setSalary();
        }
        public void setRatePerHour(double ratePerHour)
        {
            this.ratePerHour = ratePerHour;
        }

        public void setHoursWorked(int hoursWorked)
        {
            this.hoursWorked = hoursWorked;
        }

        public void setSalary()
        {
            Salary = ratePerHour * hoursWorked;
        }

        public double getRatePerHour()
        {
            return ratePerHour;
        }

        public int getHoursWorked()
        {
            return hoursWorked;
        }
        public double getSalary()
        {
            return Salary;
        }
        public override double computeSalary()
        {
            return Salary;
        }
    }
}