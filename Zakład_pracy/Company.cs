using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakład_pracy
{
    public class Company
    {
            public Company()
            {
            CreateEmp();
           
            }

        public List<Employees> Employees { get; set; } = new List<Employees>();

        public void CreateEmp()
        {
            Employees.Add(new Employees());
            Employees[0].Id = 1;
            Employees[0].Name = "Jan Nowak";
            Employees[0].DateOfBirth = new DateTime(2002, 3, 4);
            Employees[0].Title = "Pracownik fizyczny";
            Employees[0].HourRate = 18.5m;
            Employees[0].Salary = 0m;

            Employees.Add(new Employees());
            Employees[1].Id = 2;
            Employees[1].Name = "Agnieszka Kowalska";
            Employees[1].DateOfBirth = new DateTime(1973, 12, 15);
            Employees[1].Title = "Urzędnik";
            Employees[1].HourRate = 0m;
            Employees[1].Salary = 2800m;

            Employees.Add(new Employees());
            Employees[2].Id = 3;
            Employees[2].Name = "Robert Lewandowski";
            Employees[2].DateOfBirth = new DateTime(1980,5,23);
            Employees[2].Title = "Pracownik fizyczny";
            Employees[2].HourRate = 29m;
            Employees[2].Salary = 0m;

            Employees.Add(new Employees());
            Employees[3].Id = 4;
            Employees[3].Name = "Zofia Plucińska";
            Employees[3].DateOfBirth = new DateTime(1998,11,2);
            Employees[3].Title = "Urzędnik";
            Employees[3].HourRate = 0m;
            Employees[3].Salary = 4750m;

            Employees.Add(new Employees());
            Employees[4].Id = 5;
            Employees[4].Name = "Grzegorz Braun";
            Employees[4].DateOfBirth = new DateTime(1960,1,29);
            Employees[4].Title = "Pracownik fizyczny";
            Employees[4].HourRate = 48m;
            Employees[4].Salary = 0m;
          
        }
    }

}
