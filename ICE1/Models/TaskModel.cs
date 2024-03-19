using System.ComponentModel.DataAnnotations;

namespace ICE1Project.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Title { get; set; }
        [StringLength(200, MinimumLength = 2)]
        public string? Description { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartTask { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndTask { get; set; }
    }
}
