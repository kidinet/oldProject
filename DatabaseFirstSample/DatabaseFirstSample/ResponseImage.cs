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
    
    public partial class ResponseImage
    {
        public Nullable<int> imageId { get; set; }
        public Nullable<System.DateTime> date_added { get; set; }
        public string text { get; set; }
        public string userMail { get; set; }
    
        public virtual ImageGallery ImageGallery { get; set; }
        public virtual User User { get; set; }
    }
}
