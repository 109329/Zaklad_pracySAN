using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakład_pracy
{
    public  class Screen
    {
       public static string Open()
        {

            Console.WriteLine("WYBIERZ OPCJĘ: \n 1. LISTA WSZYSTKICH PRACOWNIKÓW \n 2. WYLICZ PENSJĘ PRACOWNIKÓW \n 3. ZAKOŃCZ PROGRAM \n WYBIERZ 1, 2 LUB 3: ");
           return Console.ReadLine();
          


        }
        public static void FindID()
        {
            
            Company company = new Company();
            
            Console.WriteLine("Podaj ID pracownika: ");
            string id = Console.ReadLine();
            Console.WriteLine("--------------------");

            if (id == "1" || id == "3" || id == "5")

            {
                int givenid;
                givenid = int.Parse(id);
                Console.WriteLine($"{company.Employees[givenid - 1].Id}. {company.Employees[givenid - 1].Name}\nWIEK: {company.Employees[givenid - 1].Age}\nSTANOWSIKO: {company.Employees[givenid - 1].Title}\nSTAWKA GODZINOWA: {company.Employees[givenid - 1].HourRate}");
                Console.WriteLine("====================");
                Console.WriteLine();
                Console.WriteLine("Podaj ilość przepracowanych godzin: ");
                int Salary, Hours;
                string Hinput;

                Hinput = Console.ReadLine();
                Hours = int.Parse(Hinput);
                if (Hours >= 0 && Hours <= 19)
                {
                    Salary = (int)(Hours * company.Employees[givenid - 1].HourRate) * 8;
                    Console.WriteLine($"Wynagrodzenie brutto wynosi: {Salary}zł");
                    if (company.Employees[givenid - 1].Age >= 26)
                    {
                        Console.WriteLine($"Wynagrodzenie netto wynosi: {Salary - (Salary * 0.18m)} zł");
                    }
                    else
                    {
                        Console.WriteLine($"Wynagordzenie netto wynosi: {Salary} zł");
                    }
                }

                else if (Hours == 20)
                {
                    Console.WriteLine("Podaj wynagrodzenie dla pracownika: ");
                    string bonus = Console.ReadLine();
                    int bonusint;

                    if (int.TryParse(bonus, out bonusint))
                    {
                        Salary = (int)(Hours * company.Employees[givenid - 1].HourRate) * 8 +bonusint;
                        Console.WriteLine($"Wynagrodzenie brutto wynosi: {Salary}zł");
                        if (company.Employees[givenid - 1].Age >= 26)
                        {
                            Console.WriteLine($"Wynagrodzenie netto wynosi: {Salary - (Salary * 0.18m) } zł");
                            Console.WriteLine($"Potrącony podatek wynosi: {Salary*0.18m}");
                        }
                        else
                        {
                            Console.WriteLine($"Wynagordzenie netto wynosi: {Salary } zł");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowe dane!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Podane nieprawidlowe dane!!!");
                }
            
                
            }
            else if(id =="2" || id == "4")
            {
                int givenid;
                givenid = int.Parse(id);
                Console.WriteLine($"{company.Employees[givenid - 1].Id}. {company.Employees[givenid - 1].Name}\nWIEK: {company.Employees[givenid - 1].Age}\nSTANOWSIKO: {company.Employees[givenid - 1].Title}\nPENSJA: {company.Employees[givenid - 1].Salary}");
                Console.WriteLine("====================");
                Console.WriteLine();
                Console.WriteLine("Podaj ilość przepracowanych godzin: ");
                int Salary, Hours;
                string Hinput;

                Hinput = Console.ReadLine();
                Hours = int.Parse(Hinput);
                if (Hours >= 0 && Hours <= 19)
                {
                    Salary = ((int)((int)company.Employees[givenid - 1].Salary * 0.8m));
                    Console.WriteLine($"Wynagrodzenie brutto wynosi: {Salary}zł");
                    if (company.Employees[givenid - 1].Age >= 26)
                    {
                        Console.WriteLine($"Wynagrodzenie netto wynosi: {Salary - (Salary * 0.18m)} zł");
                        Console.WriteLine($"Potrącony podatek wynosi: {Salary *0.18m}");
                    }
                    else
                    {
                        Console.WriteLine($"Wynagordzenie netto wynosi: {Salary} zł");
                    }
                }

                else if (Hours == 20)
                {
                    Console.WriteLine("Podaj wynagrodzenie dla pracownika: ");
                    string bonus = Console.ReadLine();
                    int bonusint;

                    if (int.TryParse(bonus, out bonusint))
                    {
                        Salary = (int)company.Employees[givenid-1].Salary + bonusint;
                        Console.WriteLine($"Wynagrodzenie brutto wynosi: {Salary}zł");
                        if (company.Employees[givenid - 1].Age >= 26)
                        {
                            Console.WriteLine($"Wynagrodzenie netto wynosi: {Salary - (Salary * 0.18m) } zł");
                        }
                        else
                        {
                            Console.WriteLine($"Wynagordzenie netto wynosi: {Salary } zł");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowe dane!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Podane nieprawidlowe dane!!!");
                }

            }
           
            else 
            {
                Console.WriteLine("Nie ma takiego pracownika w bazie");
                Console.WriteLine();
            }
              
        }

        

        public static void ViewWorkers()
        {
            Company CreateEmp = new();
            foreach(var Worker in CreateEmp.Employees)
            {
                Console.WriteLine($"{Worker.Id} | Imię i nazwisko: {Worker.Name} | Wiek: {Worker.Age} | Stanowisko: {Worker.Title} | Stawka godzinowa: {Worker.HourRate} | Pensja miesięczna: {Worker.Salary} \n");
               
            }
            Console.WriteLine();
        }

       
        }
        

      


        
    
}
