using System.Text;

namespace LinQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Firma firma = new Firma();
            List<Firma> firms = new List<Firma>
            {
                new Firma("FoodCorp", new DateTime(1990, 5, 15), "Харчова промисловість", "John Smith", 200, "London"),
                new Firma("IT Solutions", new DateTime(2005, 8, 20), "IT", "Jane Doe", 150, "New York"),
                new Firma("Marketing Experts", new DateTime(2010, 3, 10), "Маркетинг", "Michael White", 80, "London"),
                new Firma("White House", new DateTime(2018, 12, 5), "Інше", "Peter Black", 500, "Washington, D.C."),
            };
            Console.WriteLine("Всі фірми:");
            Firma.PrintFirms(firms);

            Console.WriteLine("\n Фірми, які мають у назві слово \"Food\":");
            Firma.PrintFirms(Firma.GetFirmsWithNameContains(firms, "Food"));

            Console.WriteLine("\n Фірми, які працюють у галузі маркетингу:");
            Firma.PrintFirms(Firma.GetFirmsByBusinessProfile(firms, "Маркетинг"));

            Console.WriteLine("\n Фірми, які працюють у галузі маркетингу або IT:");
            Firma.PrintFirms(Firma.GetFirmsByBusinessProfile(firms, "Маркетинг", "IT"));

            Console.WriteLine("\n Фірми з кількістю працівників більшою, ніж 100:");
            Firma.PrintFirms(Firma.GetFirmsByEmployeeCountGreaterThan(firms, 100));

            Console.WriteLine("\n Фірми з кількістю працівників у діапазоні від 100 до 300:");
            Firma.PrintFirms(Firma.GetFirmsByEmployeeCountInRange(firms, 100, 300));

            Console.WriteLine("\n Фірми, які знаходяться в Лондоні:");
            Firma.PrintFirms(Firma.GetFirmsByCity(firms, "London"));

            Console.WriteLine("\n Фірми, в яких прізвище директора White:");
            Firma.PrintFirms(Firma.GetFirmsByDirectorLastName(firms, "White"));

            Console.WriteLine("\n Фірми, які засновані більше двох років тому:");
            Firma.PrintFirms(Firma.GetFirmsFoundedBefore(firms, DateTime.Now.AddYears(-2)));

            Console.WriteLine("\n Фірми з дня заснування яких минуло 123 дні:");
            Firma.PrintFirms(Firma.GetFirmsFoundedBefore(firms, DateTime.Now));

            Console.WriteLine("\n Фірми, в яких прізвище директора Black і мають у назві фірми слово \"White\":");
            Firma.PrintFirms(Firma.GetFirmsByDirectorLastNameAndNameContains(firms, "Black", "White"));
        }
    }
}