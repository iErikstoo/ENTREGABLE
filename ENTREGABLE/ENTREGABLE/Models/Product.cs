using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENTREGABLE.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public String Package { get; set; }
        public bool IsDiscontinued { get; set; } = false;
        [ForeignKey("SupplierId")]
        public  Supplier Supplier { get; set; }
        public ICollection<OrderItem>? OrderItems{ get; set; }
    }
}
