using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Bill
{
    public int Id { get; set; }

    public DateOnly Datecheckin { get; set; }

    public DateOnly Datecheckout { get; set; }

    public int IdTable { get; set; }

    public int Status { get; set; }

    public virtual ICollection<Billinfo> Billinfos { get; set; } = new List<Billinfo>();

    public virtual Tablefood IdTableNavigation { get; set; } = null!;
}
