using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempName, tempSurname, tempDateString;
            DateTime tempBirthday;
            Console.WriteLine("Enter name: ");
            tempName = Console.ReadLine();
            Console.WriteLine("Enter surname: ");
            tempSurname = Console.ReadLine();
            Console.WriteLine("Enter date of birth (yyyy.mm.dd): ");
            tempDateString = Console.ReadLine();
            tempBirthday = DateTime.ParseExact(tempDateString, "yyyy.MM.dd", System.Globalization.CultureInfo.InvariantCulture);
            User person = new User(tempName, tempSurname, tempBirthday);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(person, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(jsonString.ToString());
            if (person.Age == 18 && person.Birthday.Month <= DateTime.Today.Month && person.Birthday.Day <= DateTime.Today.Day|| person.Age > 18)
            {
                Console.WriteLine("Piwko");
            }
            else
            {
                Console.WriteLine("Brak piwka :(");
            }
            Console.ReadLine();

        }
    }
}
