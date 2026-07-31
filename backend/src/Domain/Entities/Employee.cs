namespace PeopleManager.Domain.Entities;

public class Employee
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Document { get; private set; } = string.Empty;
    public DateTime BirthDate { get; private set; }
    public string PasswordHash { get; private set; } = string.Empty;
    public Role Role { get; private set; }
    public Guid? ManagerId { get; private set; }
    public Employee? Manager { get; private set; }
    public ICollection<EmployeePhone> Phones { get; private set; } = new List<EmployeePhone>();

    private Employee() { }

    public Employee(string firstName, string lastName, string email, string document, DateTime birthDate, string passwordHash, Role role, Guid? managerId)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Document = document;
        BirthDate = birthDate;
        PasswordHash = passwordHash;
        Role = role;
        ManagerId = managerId;
    }

    public void Update(string firstName, string lastName, string email, string document, DateTime birthDate, Role role, Guid? managerId)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Document = document;
        BirthDate = birthDate;
        Role = role;
        ManagerId = managerId;
    }

    public bool IsAdult() => BirthDate <= DateTime.Today.AddYears(-18);
}
