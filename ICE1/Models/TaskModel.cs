using System.ComponentModel.DataAnnotations;

namespace ICE1Project.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartTask { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndTask { get; set; }
    }
}
