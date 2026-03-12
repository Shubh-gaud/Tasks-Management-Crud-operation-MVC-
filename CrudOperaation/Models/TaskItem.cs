using System.ComponentModel.DataAnnotations;

public class TaskItem
{
    public int Id { get; set; }

    [Required]
    public string TaskTitle { get; set; } = string.Empty;

    [Required]
    public string TaskDescription { get; set; } = string.Empty;

    public DateTime TaskDueDate { get; set; }

    public string TaskStatus { get; set; } = "Pending";

    public string? TaskRemarks { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.Now;

    public DateTime? LastUpdatedOn { get; set; }

    public string CreatedByName { get; set; } = string.Empty;

    public int CreatedById { get; set; }

    public string? LastUpdatedByName { get; set; }

    public int? LastUpdatedById { get; set; }
}