namespace Topic2.Models;

public class User
{
    private int id;
    private string username;
    private string hashPassword;
    private int userRanking; // định nghĩa sau
    private int userType;
    
    public int Id { get => id; set => id = value; } 
    public string Username { get => username; set => username = value; }
    public string HashPassword { get => hashPassword; set => hashPassword = value; }
    public int UserRanking { get => userRanking; set => userRanking = value; }
    public int UserType { get => userType; set => userType = value; }

    public User()
    {
        // constructor
    }

    ~User()
    {
        // destructor
    }
}