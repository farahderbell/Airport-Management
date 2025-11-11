using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public int Id { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Staff ID: {Id}, Name: {FirstName} {LastName}, Function: {Function}, Salary: {Salary}, Employment Date: {EmploymentDate.ToShortDateString()}";
        }
        public override void PassengerType()
        {
           Console.WriteLine("I am a staff member");
        }

    }


}
