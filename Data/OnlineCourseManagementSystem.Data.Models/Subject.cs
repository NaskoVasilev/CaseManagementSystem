namespace OnlineCourseManagementSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using OnlineCourseManagementSystem.Data.Common.Models;

    public class Subject : BaseDeletableModel<int>
    {
        public Subject()
        {
            this.Courses = new HashSet<Course>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ModuleEntity Module { get; set; }

        public int? ModuleId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
