using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace efcore_generate_dbcontext_for_existing_db.Models
{
    [Table("ProductOrder")]
    [Index(nameof(OrderId), Name = "IX_ProductOrder_OrderId")]
    [Index(nameof(ProductId), Name = "IX_ProductOrder_ProductId")]
    public partial class ProductOrder
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("ProductOrders")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductOrders")]
        public virtual Product Product { get; set; }
    }
}
