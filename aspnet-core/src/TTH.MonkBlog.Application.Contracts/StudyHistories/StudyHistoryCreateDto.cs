using System;
using System.ComponentModel.DataAnnotations;

namespace TTH.MonkBlog.StudyHistories
{
    public class StudyHistoryCreateDto
    {
        public string Diploma { get; set; }
        public string AcademicLevel { get; set; }
        public string StudyAt { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Achievements { get; set; }
    }
}