//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAppp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artist_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artist_Info()
        {
            this.Artist_Contact = new HashSet<Artist_Contact>();
            this.Artist_Merch = new HashSet<Artist_Merch>();
            this.Music_Earnings = new HashSet<Music_Earnings>();
            this.Performances = new HashSet<Performance>();
            this.Song_Info = new HashSet<Song_Info>();
        }
    
        public int Artist_Id { get; set; }
        public string Artist_Name { get; set; }
        public string Real_Name { get; set; }
        public string Nationality { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artist_Contact> Artist_Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artist_Merch> Artist_Merch { get; set; }
        public virtual Artist_Payout Artist_Payout { get; set; }
        public virtual Artist_Socials Artist_Socials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Music_Earnings> Music_Earnings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Performance> Performances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song_Info> Song_Info { get; set; }
    }
}
