using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Tablefood
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
