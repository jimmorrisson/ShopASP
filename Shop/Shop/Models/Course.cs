using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public string TitleOfCourse { get; set; }
        public string AuthorOfCourse { get; set; }
        public DateTime AddedDateTime { get; set; }
        public string NameOfFileImage { get; set; }
        public string DescriptionOfCourse { get; set; }
        public decimal Price { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }
        public virtual Category Category { get; set; }
    }
}