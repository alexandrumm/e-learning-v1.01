//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_LearningApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Forums
    {
        public Forums()
        {
            this.Messages = new HashSet<Messages>();
        }
    
        public int ForumId { get; set; }
        public string Category { get; set; }
        public Nullable<int> OwnerId { get; set; }
    
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual Users Users { get; set; }
    }
}
