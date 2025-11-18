using OneToOneRelation2.Models;

namespace OneToOneRelation2;

public class ContactInfo
{
    public int Id { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
