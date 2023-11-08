using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENTREGABLE.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string ProductName { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        [MaxLength(64)]
        public String Package { get; set; }
        public bool IsDiscontinued { get; set; } = false;
        [ForeignKey("SupplierId")]
        public  Supplier? Supplier { get; set; }
        public ICollection<OrderItem>? OrderItems{ get; set; }
    }
}
