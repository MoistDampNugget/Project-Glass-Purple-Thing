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
    
    public partial class Song_Info
    {
        public string ISRC { get; set; }
        public string UPC { get; set; }
        public Nullable<int> Artist_ID { get; set; }
        public Nullable<int> Minutes_Listened { get; set; }
        public Nullable<int> Total_Listeners { get; set; }
    
        public virtual Artist_Info Artist_Info { get; set; }
        public virtual Music_Release Music_Release { get; set; }
    }
}
