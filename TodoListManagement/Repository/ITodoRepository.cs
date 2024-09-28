

using TodoListManagement.Models;

namespace TodoListManagement.Repository;

public interface ITodoRepository : IRepository<Todo , Guid>
{
    List<Todo> GetAllByTitleContains(string title);
}
