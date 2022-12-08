using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Regmodel
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public string email { get; set; }
    }
}
