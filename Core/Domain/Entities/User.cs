using Domain.Entities.Base;
using Domain.Entities.Interfaces;

namespace Domain.Entities;

public class User : AuditEntity<Int32>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
}