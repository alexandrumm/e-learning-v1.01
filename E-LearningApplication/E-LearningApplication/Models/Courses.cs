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
    
    public partial class Courses
    {
        public Courses()
        {
            this.CalendarEvents = new HashSet<CalendarEvents>();
            this.CourseModule = new HashSet<CourseModule>();
            this.Questions = new HashSet<Questions>();
            this.Tests = new HashSet<Tests>();
            this.UsersInCourse = new HashSet<UsersInCourse>();
            this.Homeworks = new HashSet<Homeworks>();
            this.HomeworkAssignements = new HashSet<HomeworkAssignements>();
        }
    
        public int CourseId { get; set; }
        public Nullable<int> NumberOfCredits { get; set; }
        public string CourdeCode { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> SyllabusId { get; set; }
        public string CourseName { get; set; }
        public string enrollementKey { get; set; }
    
        public virtual ICollection<CalendarEvents> CalendarEvents { get; set; }
        public virtual ICollection<CourseModule> CourseModule { get; set; }
        public virtual Users Users { get; set; }
        public virtual Syllabus Syllabus { get; set; }
        public virtual ICollection<Questions> Questions { get; set; }
        public virtual ICollection<Tests> Tests { get; set; }
        public virtual ICollection<UsersInCourse> UsersInCourse { get; set; }
        public virtual ICollection<Homeworks> Homeworks { get; set; }
        public virtual ICollection<HomeworkAssignements> HomeworkAssignements { get; set; }
    }
}
