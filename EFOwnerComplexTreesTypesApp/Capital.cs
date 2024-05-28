using System;
using System.Collections.Generic;

namespace EFOwnerComplexTreesTypesApp;

public partial class Capital
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    //public int CountryId { get; set; }

    public Country? Country { get; set; }
}
