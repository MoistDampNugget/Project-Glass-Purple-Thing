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
    
    public partial class Music_Earnings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Music_Earnings()
        {
            this.Artist_Payout = new HashSet<Artist_Payout>();
            this.Music_Release = new HashSet<Music_Release>();
        }
    
        public int Internal_Id { get; set; }
        public Nullable<double> Spotify_Earnings { get; set; }
        public Nullable<double> Apple_Earnings { get; set; }
        public Nullable<double> Bandcamp_Earnings { get; set; }
        public Nullable<double> Youtube_Earnings { get; set; }
        public Nullable<double> Total_Owed { get; set; }
        public Nullable<int> Artist_Id { get; set; }
    
        public virtual Artist_Info Artist_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artist_Payout> Artist_Payout { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Music_Release> Music_Release { get; set; }
    }
}