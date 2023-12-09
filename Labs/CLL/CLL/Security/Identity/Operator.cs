namespace Labs.CLL.CLL.Security.Identity
{
    public class Operator : User
    {
        public Operator(int userId, string username)
            : base(userId, username,  nameof(Operator))
        {
        }
    }
}