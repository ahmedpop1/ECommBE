using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class CPhone
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("Admin")]
        public int? AdminID { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
