using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakład_pracy
{
    public class Employees
    {
      

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set;}
        public string Title { get; set; }   
        public decimal HourRate { get; set; }
        public decimal Salary { get; set; }
        public int Age 
                { 
                    get { return DateTime.Now.Year - DateOfBirth.Year; }
                
                }


    }
}
