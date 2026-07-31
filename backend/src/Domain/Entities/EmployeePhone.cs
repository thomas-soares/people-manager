namespace PeopleManager.Domain.Entities;

public class EmployeePhone
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Number { get; private set; } = string.Empty;
    public Guid EmployeeId { get; private set; }
    public Employee Employee { get; private set; } = default!;

    private EmployeePhone() { }

    public EmployeePhone(string number, Guid employeeId)
    {
        Number = number;
        EmployeeId = employeeId;
    }
}
