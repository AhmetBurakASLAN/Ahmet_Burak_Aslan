//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doktorlar
    {
        public int ID { get; set; }
        public string SicilNo { get; set; }
        public string AdSoyad { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int BolumID { get; set; }
    
        public virtual Bolumler Bolumler { get; set; }
    }
}
