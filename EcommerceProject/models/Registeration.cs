using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Registeration
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        [ForeignKey("Admin")]
        public int? AdminID { get; set; }
        public Admin Admin { get; set; }
        [ForeignKey("customer")]
        public int? CustomerID { get; set; }
        public Customer customer { get; set; }

    }
}
