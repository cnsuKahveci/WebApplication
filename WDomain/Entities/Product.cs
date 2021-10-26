
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
        /* Entity framework foreign keyi olusturuyor, tabloları baglayabiliyor
        *  Id yi kendimiz verdik, entity framework bu alnı pass gecmesi icin attribute kullanıyoruz
        */
        
        //lazyloadign yapmak için virtual kullanılmalı-> override edilebilir olması icin
        [ForeignKey(("CategoryId"))]
        public virtual Category Category { get; set; }
    /*
     * Order mutlaka bir product'ta bagli olmalı anlamına geliyor
        public Order Order { get; set; }
    */

    }
}