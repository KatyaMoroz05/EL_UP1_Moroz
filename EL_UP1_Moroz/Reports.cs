//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EL_UP1_Moroz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reports()
        {
            this.ReportsAndMaterials = new HashSet<ReportsAndMaterials>();
        }
    
        public int id { get; set; }
        public int id_requests { get; set; }
        public int time { get; set; }
        public decimal sum { get; set; }
        public string description { get; set; }
    
        public virtual Requests Requests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportsAndMaterials> ReportsAndMaterials { get; set; }
    }
}
