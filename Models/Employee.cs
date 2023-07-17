using System.ComponentModel.DataAnnotations.Schema;

namespace TesteLibraryApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string LastName { get; set; }
        
        public int TabelNubmer { get; set; }

        //[Column("DivisionID11")]
        public int DivisionID { get; set; }
        public Division? Division { get; set; }
       
    }
}
