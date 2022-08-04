using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Admin
    {
        public int Id { get; set; }
        public byte[] image { get; set; }

        public string FullName { get; set; }
        [ForeignKey("Registeration")]
        [Required]
        public string UserName { get; set; }
        public Registeration Registeration { get; set; }
        public string Address { get; set; }
        public virtual ICollection<CPhone> CPhones { get; set; }
         = new List<CPhone>();

    }
}
