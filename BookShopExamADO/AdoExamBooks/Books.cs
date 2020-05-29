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
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.Discounts = new HashSet<Discounts>();
            this.NextTome = new HashSet<NextTome>();
            this.Reservations = new HashSet<Reservations>();
            this.Sales = new HashSet<Sales>();
        }
    
        public int Id_Book { get; set; }
        public int Id_Theme { get; set; }
        public int Id_Author { get; set; }
        public int Id_Publisher { get; set; }
        public string NameBook { get; set; }
        public int Pages { get; set; }
        public int DrawingOfBook { get; set; }
        public System.DateTime DateOfPublish { get; set; }
        public int Year { get; set; }
        public decimal ProductPrice { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Publishers Publishers { get; set; }
        public virtual Themes Themes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discounts> Discounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NextTome> NextTome { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservations> Reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}