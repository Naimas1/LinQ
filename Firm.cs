
namespace LinQ
{
    public class Firma
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorName { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }
        public Firma()
        {
            Name = string.Empty;
            FoundationDate = DateTime.Now;
            BusinessProfile = string.Empty;
            DirectorName = string.Empty;
            EmployeeCount = 0;
            Address = string.Empty;
        }

        public Firma(string name, DateTime foundationDate, string businessProfile, string directorName, int employeeCount, string address)
        {
            Name = name;
            FoundationDate = foundationDate;
            BusinessProfile = businessProfile;
            DirectorName = directorName;
            EmployeeCount = employeeCount;
            Address = address;
        }
        public static List<Firma> GetAllFirms(List<Firma> firms) => firms;
        public static List<Firma> GetFirmsWithNameContains(List<Firma> firms, string keyword)
        {
            return firms.Where(f => f.Name.Contains(keyword)).ToList();
        }
        public static List<Firma> GetFirmsByBusinessProfile(List<Firma> firms, string businessProfile)
        {
            return firms.Where(f => f.BusinessProfile == businessProfile).ToList();
        }
        public static List<Firma> GetFirmsByBusinessProfile(List<Firma> firms, string businessProfile1, string businessProfile2)
        {
            return firms.Where(f => f.BusinessProfile == businessProfile1 || f.BusinessProfile == businessProfile2).ToList();
        }
        public static List<Firma> GetFirmsByEmployeeCountGreaterThan(List<Firma> firms, int employeeCount)
        {
            return firms.Where(f => f.EmployeeCount > employeeCount).ToList();
        }
        public static List<Firma> GetFirmsByEmployeeCountInRange(List<Firma> firms, int minEmployeeCount, int maxEmployeeCount)
        {
            return firms.Where(f => f.EmployeeCount >= minEmployeeCount && f.EmployeeCount <= maxEmployeeCount).ToList();
        }
        public static List<Firma> GetFirmsByCity(List<Firma> firms, string city)
        {
            return firms.Where(f => f.Address.Contains(city)).ToList();
        }
        public static List<Firma> GetFirmsByDirectorLastName(List<Firma> firms, string directorLastName)
        {
            return firms.Where(f => f.DirectorName.EndsWith(directorLastName)).ToList();
        }
        public static List<Firma> GetFirmsFoundedBefore(List<Firma> firms, DateTime date)
        {
            return firms.Where(f => f.FoundationDate < date).ToList();
        }
        public static List<Firma> GetFirmsFoundedBefore(List<Firma> firms, int nDays)
        {
            return GetFirmsFoundedBefore(firms, DateTime.Now.AddDays(-nDays));
        }
        public static List<Firma> GetFirmsByDirectorLastNameAndNameContains(List<Firma> firms, string directorLastName, string keyword)
        {
            return firms.Where(f => f.DirectorName.EndsWith(directorLastName) && f.Name.Contains(keyword)).ToList();
        }
        public static void PrintFirms(List<Firma> firms)
        {
            foreach (var firma in firms)
            {
                Console.WriteLine($"Назва: {firma.Name}");
                Console.WriteLine($"Дата заснування: {firma.FoundationDate:dd.MM.yyyy}");
                Console.WriteLine($"Профіль бізнесу: {firma.BusinessProfile}");
                Console.WriteLine($"Директор: {firma.DirectorName}");
                Console.WriteLine($"Кількість працівників: {firma.EmployeeCount}");
                Console.WriteLine($"Адреса: {firma.Address}\n");
            }
        }
    }
}