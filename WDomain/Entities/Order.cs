
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WDomain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public virtual User User { get; set; }
        public double TotalPrice { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderItems> OderItems { get; set; }
    }

    public class OrderItems
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        
        [ForeignKey("OrderId")] 
        public virtual Order Order { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")] 
        public Product Product { get; set; }
        public int Piece { get; set; }
        public double Total { get; set; }

      }
}