using Labs.Entities;

namespace Labs.CLL.CLL.Security.Identity;

public abstract class User
{
    public User(int userId, string username, string userType)
    {
        UserId = userId;
        Username = username;
        UserType = userType;
    }

    public int UserId{ get; set; }
    public string Username { get; set; }
    protected string UserType { get; }
}
