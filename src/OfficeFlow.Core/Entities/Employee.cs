using OfficeFlow.Core.ValueObjects;

namespace OfficeFlow.Core.Entities;

public sealed class Employee : User
{
    public double? HourlyRate { get; private set; }
    public string Position { get; private set; }
    public Date HiredDate { get; private set; }

    public Employee(UserId id, UserName name, UserSurname surname,
        Login login, Email email, string password, string role,
        bool isActive, Date cratedAt, double hourlyRate,
        string position, Date hiredDate)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Login = login;
        Email = email;
        Passowrd = password;
        Role = role;
        IsActive = isActive;
        CreatedAt = cratedAt;
        HourlyRate = hourlyRate;
        Position = position;
        HiredDate = hiredDate;
    }
}
