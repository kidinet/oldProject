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
<<<<<<< HEAD
=======
<<<<<<< HEAD
    
=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
            this.abouts = new HashSet<about>();
            this.formDilemmas = new HashSet<formDilemma>();
            this.imageGalleries = new HashSet<imageGallery>();
            this.reminders = new HashSet<reminder>();
            this.thisWeekTitles = new HashSet<thisWeekTitle>();
            this.topMessages = new HashSet<topMessage>();
            this.UserInGroups = new HashSet<UserInGroup>();
        }

=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
            this.imageGalleries = new HashSet<imageGallery>();
            this.reminders = new HashSet<reminder>();
            this.topMessages = new HashSet<topMessage>();
            this.UserInGroups = new HashSet<UserInGroup>();
            this.abouts = new HashSet<about>();
            this.thisWeekTitles = new HashSet<thisWeekTitle>();
        }
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
        public Group(string name, string city, string street, int build, string phone, string mail, string fax)
        {
            this.name = name;
            this.city = city;
            this.build = build;
            this.phone = phone;
            this.mail = mail;
            this.fax = fax;
            this.streat = street;
            this.UserInGroups = new HashSet<UserInGroup>();
            this.imageGalleries = new HashSet<imageGallery>();
            this.reminders = new HashSet<reminder>();
            this.topMessages = new HashSet<topMessage>();
            this.UserInGroups = new HashSet<UserInGroup>();
            this.abouts = new HashSet<about>();
            this.thisWeekTitles = new HashSet<thisWeekTitle>();
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string streat { get; set; }
        public Nullable<int> build { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string fax { get; set; }
        public Nullable<double> latitute { get; set; }
        public Nullable<double> longitude { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<about> abouts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formDilemma> formDilemmas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<imageGallery> imageGalleries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reminder> reminders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thisWeekTitle> thisWeekTitles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<topMessage> topMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInGroup> UserInGroups { get; set; }
=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa

        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string streat { get; set; }
        [DataMember]
        public Nullable<int> build { get; set; }
        [DataMember]
        public string phone { get; set; }
        [DataMember]
        public string mail { get; set; }
        [DataMember]
        public string fax { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<imageGallery> imageGalleries { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reminder> reminders { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<topMessage> topMessages { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInGroup> UserInGroups { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<about> abouts { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thisWeekTitle> thisWeekTitles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mainAboutTitle> mainAboutTitles { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
    }
}
