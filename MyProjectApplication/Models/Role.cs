namespace MyProjectApplication.Models;


public class User
{
    public int Id { get; set; }
    
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public int RoleId { get; set; } 
}




public class Role
{
    public string Name { get; set; }
    
    public  int  Id{ get; set; }
}

