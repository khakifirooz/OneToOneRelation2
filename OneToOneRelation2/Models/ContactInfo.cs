using System.ComponentModel.DataAnnotations.Schema;
using OneToOneRelation2.Models;

namespace OneToOneRelation2;

public class ContactInfo
{
    public int Id { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }

  //  [ForeignKey("Employee")] 
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
