using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{

    public enum CategoryStatus
    {
        ACTIVE = 1,
        INACTIVE = 0
    }

    [Table("tblCategory")]
    public class Category
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string CategoryId { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        [Required]
        [StringLength(500)]
        public string Description { set; get; }

        [Required]
        public CategoryStatus Status { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateDate { set; get; }

        public override string ToString()
        {
            return "Category: \nCategoryId: " + CategoryId + " \nName: " + Name + " \nDescription: " + Description +
            " \nCreateDate: " + CreateDate + " \nStatus: " + Status;
        }
    }
}