using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace ENTREGABLE.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public int Quantity { get; set; } = 1;
        [ForeignKey("OrderId")]
        public  Order Order  { get; set; }
        [ForeignKey("ProductId")]
        public  Product Product { get; set; }
    }
  
}
