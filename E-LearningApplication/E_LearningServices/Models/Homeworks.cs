//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_LearningServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Homeworks
    {
        public Homeworks()
        {
            this.HomeworkAssignements = new HashSet<HomeworkAssignements>();
        }
    
        public int HomeworkId { get; set; }
        public string HomeworkCode { get; set; }
        public string HomeworkName { get; set; }
        public string HomeworkDescription { get; set; }
        public Nullable<System.DateTime> HomeworkDeadline { get; set; }
        public Nullable<decimal> HomeworkPoints { get; set; }
        public Nullable<System.DateTime> HomeworkAccessSpan { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> CourseModuleId { get; set; }
        public Nullable<int> OwnerId { get; set; }
    
        public virtual CourseModule CourseModule { get; set; }
        public virtual Courses Courses { get; set; }
        public virtual ICollection<HomeworkAssignements> HomeworkAssignements { get; set; }
        public virtual Users Users { get; set; }
    }
}
