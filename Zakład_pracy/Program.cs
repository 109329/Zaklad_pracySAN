// See https://aka.ms/new-console-template for more information
using Zakład_pracy;



string choice = Screen.Open();
if(choice == "1")
{
    Screen.ViewWorkers();
}
else if(choice == "2")
{
    Screen.FindID();
}
else if(choice == "3")
{
    Console.WriteLine("Do zobaczenia!!!");
}
else
{
    Console.WriteLine("Podano złe dane!!!");
}

