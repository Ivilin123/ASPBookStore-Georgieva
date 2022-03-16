using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPBStore.Models
{
    public class OrdersVM
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<SelectListItem> User { get; set; }

        public int ProductId { get; set; }
        public List<SelectListItem> Product { get; set; }
        public int AmountOrdered { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceOrder { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
