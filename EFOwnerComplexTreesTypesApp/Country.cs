using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFOwnerComplexTreesTypesApp;

[ComplexType]
public partial class Country
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    //public virtual Capital? Capital { get; set; }

    //public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
