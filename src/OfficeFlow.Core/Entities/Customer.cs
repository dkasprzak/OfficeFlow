using OfficeFlow.Core.ValueObjects;

namespace OfficeFlow.Core.Entities;

public sealed class Customer : User
{
    public Pesel Pesel { get; private set; }
    public IdCardNumber IdCardNumber { get; private set; }
    public PostalCode PostalCode { get; private set; }
    public string City { get; private set; }
    public string Country { get; private set; }
    public IEnumerable<Project> Projects => _projects;
    
    private readonly HashSet<Project> _projects = new();

    public Customer(UserId id, UserName name, UserSurname surname,
        Login login, Email email, string password, string role,
        bool isActive, Pesel pesel, IdCardNumber idCardNumber, PostalCode postalCode,
        string city, string country, Date createdAt)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Login = login;
        Email = email;
        Passowrd = password;
        Role = role;
        IsActive = isActive;
        CreatedAt = createdAt;
        Pesel = pesel;
        IdCardNumber = idCardNumber;
        PostalCode = postalCode;
        City = city;
        Country = country;
    }
    
    public static Customer Create(string name, string surname,
        string login, string email, string password, string role,
        string pesel, string idCardNumber, string postalCode,
        string city, string country)
    {
        User user = new();
        return new(user.Id, name, surname, login,
            email, password, role, true, pesel, idCardNumber,
            postalCode, city, country, new Date(DateTimeOffset.UtcNow));
    }        
    
    public void AddProject(Project project)
    {
        _projects.Add(project);
    }

    public void RemoveProject(Guid id)
        => _projects.RemoveWhere(x => x.Id.Value == id);


}
