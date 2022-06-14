using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_payroll
{
    internal class Data
    {
        private double Document;
        private string FirstName;
        private string LastName;
        private double Salary;
        private double WorkedDays;
        private double TotalAccrued;
        private double TransportSubsidy;
        private double Healt;
        private double Pension;

        public Data() { }

        public Data(double document, string firstName, string lastName, double salary, double workedDays, double totalAccrued, double transportSubsidy, double healt, double pension)
        {
            this.Document = document;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.WorkedDays = workedDays;
            this.TotalAccrued = totalAccrued;
            this.TransportSubsidy = transportSubsidy;
            this.Healt = healt;
            this.Pension = pension;
        }
        public double document { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double salary { get; set; }
        public double workedDays { get; set; }
        public double totalAccrued { get; set; }
        public double transportSubsidy { get; set; }
        public double healt { get; set; }
        public double pension { get; set; }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
