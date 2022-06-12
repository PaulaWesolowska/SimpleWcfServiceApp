ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
Console.WriteLine("Podaj nazwisko");
var lastName = Console.ReadLine();
string result = client.GetPersonData(lastName);
Console.WriteLine(result);