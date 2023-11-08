﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace ENTREGABLE.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; } = 0;
        [Required]
        public int Quantity { get; set; } = 1;
        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
        public decimal? Subtotal { get; set; } = 0;
    }
}

