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
    
    public partial class Order
    {
        public Order()
        {
            this.Orders_Items = new HashSet<Orders_Items>();
        }
    
        public long orderID { get; set; }
        public long userID { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Orders_Items> Orders_Items { get; set; }
    }
}