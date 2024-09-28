

namespace TodoListManagement.Models;

public sealed class Todo : Entity<Guid>
{
   
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }

    public string StartDate { get; set; }

    public string EndDate { get; set; }

    public string Priority { get; set; }

    public bool IsComleted { get; set; }

    public int UserId { get; set; }

}
