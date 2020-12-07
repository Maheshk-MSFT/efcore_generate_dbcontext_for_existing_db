using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace efcore_generate_dbcontext_for_existing_db.Models
{
    [Index(nameof(CustomerId), Name = "IX_Orders_CustomerId")]
    public partial class Order
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullfilled { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }
        [InverseProperty(nameof(ProductOrder.Order))]
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
