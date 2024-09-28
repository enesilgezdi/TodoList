

namespace TodoListManagement.Models;

public sealed class User : Entity<long>
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    public string Password { get; set; }

    public int Age { get; set; }

}
