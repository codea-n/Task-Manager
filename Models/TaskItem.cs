using System.ComponentModel.DataAnnotations; // Needed for validation attributes

namespace TaskManagerMVC.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be more than 100 characters")]
        [Display(Name = "Task Title")]

        public required string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}