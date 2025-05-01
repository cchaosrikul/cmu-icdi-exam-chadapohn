using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cmu_icdi_exam_chadapohn.Models
{
    public class Blogs
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [DisplayName("หัวข้อ")]
        public string BlogTitle { get; set; }

        [Required]
        [DisplayName("เนื้อหา")]
        public string BlogContent { get; set; }
    }
}
