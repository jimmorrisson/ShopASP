using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Enter the name of category"), StringLength(100)]
        public string NameOfCategory { get; set; }
        [Required(ErrorMessage ="Enter description of category")]
        public string DescriptionOfCategory { get; set; }
        public string NameOfFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}