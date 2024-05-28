using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFOwnerComplexTreesTypesApp;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public int? CompanyId { get; set; }

    public int? PositionId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();

    public virtual Position? Position { get; set; }

    public EmployeeInfo? EmployeeInfo { get; set; }

    public required Country Country { get; set; }
}

//[Owned]
public class EmployeeInfo
{
    public string? PassportSeries { get; set; }
    public int? PassportNumber { get; set; }
}
