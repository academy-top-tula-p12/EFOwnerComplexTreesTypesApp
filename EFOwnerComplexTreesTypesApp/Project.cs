using System;
using System.Collections.Generic;

namespace EFOwnerComplexTreesTypesApp;

public partial class Project
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
}
