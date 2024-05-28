using System;
using System.Collections.Generic;

namespace EFOwnerComplexTreesTypesApp;

public partial class EmployeeProject
{
    public int EmployeeId { get; set; }

    public int ProjectId { get; set; }

    public DateTime FinishDate { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
