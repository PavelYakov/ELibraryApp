namespace TesteLibraryApp.Models
{
    public class Division
    {
        public int ID { get; set; }
        public string NameDivision { get; set; }
        public int? ParentDivisionsId { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
