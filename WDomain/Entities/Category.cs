using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WDomain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //Collection 1-n, n-n ilişki icin kullanılıyor
        public virtual ICollection<Product> Products { get; set; }
    /*
        //parentId null gelirse hata dönmesin, null ise dokunma anlamında ? kullanılıyor.
        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")] 
        public Category ParentCategory { get; set; }
        //alt katogoriler ile iliski kuruyor
        public ICollection<Category> SubCategories { get; set; }
    */
    }
}