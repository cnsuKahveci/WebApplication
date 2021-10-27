
﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WDomain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey(("CategoryId"))]
        public virtual Category Category { get; set; }
    /*
     * Order mutlaka bir product'ta bagli olmalı anlamına geliyor
        public Order Order { get; set; }
    */

    }
}