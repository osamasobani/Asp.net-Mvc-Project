//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudySchedule
    {
        public int Id { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> DayId { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public Nullable<int> SectionId { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Day Day { get; set; }
        public virtual Section Section { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}