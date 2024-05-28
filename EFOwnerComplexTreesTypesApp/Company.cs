using System;
using System.Collections.Generic;

namespace EFOwnerComplexTreesTypesApp;

public partial class Company
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    //public int? CountryId { get; set; }

    public required Country Country { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
