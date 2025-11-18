

using OneToOneRelation2;
using OneToOneRelation2.Models;

using AppDb context = new();
var contactInfo = new ContactInfo()
{
    Mobile = "123-456-7890",
    Address = "123 Main St, Anytown, USA"
};
var employee = new Employee()
{
    Name = "John Doe",
    famFamilyily = "Doe Family",
    ContactInfo = contactInfo
};

context.Employees.Add(employee);
context.SaveChanges();


Console.ReadKey();