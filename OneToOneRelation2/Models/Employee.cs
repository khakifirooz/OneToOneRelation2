namespace OneToOneRelation2.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Family { get; set; }
    public ContactInfo ContactInfo { get; set; }
}
