//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_DB_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.Carts_Items = new HashSet<Carts_Items>();
            this.Orders_Items = new HashSet<Orders_Items>();
        }
    
        public long itemID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public string category { get; set; }
    
        public virtual ICollection<Carts_Items> Carts_Items { get; set; }
        public virtual ICollection<Orders_Items> Orders_Items { get; set; }
    }
}
