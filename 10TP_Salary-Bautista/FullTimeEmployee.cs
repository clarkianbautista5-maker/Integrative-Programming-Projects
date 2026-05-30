using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10TP_Payroll_Bautista;

namespace PayrollNamespace
{
    public class FullTimeEmployee : Employee, IEmployee
    {
        private string fName;
        private string lName;
        private string department;
        private string jobTitle;
        private double Salary;
        private double monthlySalary;

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

        public FullTimeEmployee(string name, double monthlySalary)
            : base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public void setMonthlySalary(double monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

        public double getMonthlySalary()
        {
            return monthlySalary;
        }

        public override double computeSalary()
        {
            return monthlySalary;
        }
    }
}
