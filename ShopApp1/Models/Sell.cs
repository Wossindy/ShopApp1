//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sell
    {
        public int SellId { get; set; }
        public int CoodId { get; set; }
        public System.DateTime DateSell { get; set; }
        public int SellCount { get; set; }
    
        public virtual Good Good { get; set; }
    }
}
