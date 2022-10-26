using System.ComponentModel.DataAnnotations;

namespace test_API.Models
{
    public class employee
    {
        public double id { get; set; }
        public string name { get; set; }

        public decimal salary { get; set; }

       // [DataType(DataType.Date)]
        public DateTime dateOfBrith { get; set; }

        //[DataType(DataType.EmailAddress)]
        public string email { get; set; }
    
    }
}
