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
    
    public partial class Discounts
    {
        public int Id_Discounts { get; set; }
        public double DiscountPercent { get; set; }
        public int Id_Book { get; set; }
    
        public virtual Books Books { get; set; }
    }
}
