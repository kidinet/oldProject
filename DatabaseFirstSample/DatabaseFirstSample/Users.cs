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
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.UserInGroups = new HashSet<UserInGroup>();
        }
    
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public string childLastName { get; set; }
        [DataMember]
        public string nickname { get; set; }
        [DataMember]
        public string profile_ { get; set; }
        [DataMember]
        public string mail { get; set; }
        [DataMember]
        public string password_ { get; set; }
        [DataMember]
        public Nullable<bool> type_ { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string streat { get; set; }
        [DataMember]
        public Nullable<int> build { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInGroup> UserInGroups { get; set; }
    }
}