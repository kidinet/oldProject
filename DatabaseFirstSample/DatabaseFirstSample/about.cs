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
    
    public partial class about
    {
        public int id { get; set; }
<<<<<<< HEAD
=======
<<<<<<< HEAD
        public Nullable<int> groupId { get; set; }
        public string title { get; set; }
        public string icon { get; set; }
        public string color { get; set; }
=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
        public string title { get; set; }
        public string icon { get; set; }
        public Nullable<int> groupId { get; set; }
        public string content { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
    
        public virtual Group Group { get; set; }
    }
}
