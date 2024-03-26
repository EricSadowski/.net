

namespace College.Areas.Staff.Models
{
    public class TaskListViewModel
    {
        public IEnumerable<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    }
}
