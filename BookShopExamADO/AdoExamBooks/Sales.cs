//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoExamBooks
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int Id_Sale { get; set; }
        public int Id_Buyer { get; set; }
        public int Id_Book { get; set; }
        public System.DateTime DateOfSale { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Buyers Buyers { get; set; }
    }
}
