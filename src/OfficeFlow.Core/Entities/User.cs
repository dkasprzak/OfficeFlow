using OfficeFlow.Core.ValueObjects;

namespace OfficeFlow.Core.Entities;

public class User
{
    public UserId Id { get; set; }
    public UserName Name { get; set; }
    public UserSurname Surname { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
    public Login Login { get; set; }
    //TO-DO
    public Email Email { get; set; }
    //TO-DO 
    public string Passowrd { get; set; }
    public string Role { get; set; }
    public bool IsActive { get; set; }
    public Date CreatedAt { get; set; }
    
}
