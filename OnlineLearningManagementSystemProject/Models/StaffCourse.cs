﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningManagementSystemProject.Models
{
    public class StaffCourse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int StaffId { get; set; }
        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course course { get; set; }
    }
}
