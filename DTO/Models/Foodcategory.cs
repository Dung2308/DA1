using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Foodcategory
{
    public int Id { get; set; }

    public string Tenmon { get; set; } = null!;

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
}
