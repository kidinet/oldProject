//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class thisWeekTitle
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> groupId { get; set; }
    
        public virtual Group Group { get; set; }
=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thisWeekTitle()
        {
            this.imageInThisWeekTitles = new HashSet<imageInThisWeekTitle>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> groupId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<imageInThisWeekTitle> imageInThisWeekTitles { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
    }
}
