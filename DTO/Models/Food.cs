using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Food
{
    public int Id { get; set; }

    public string Tenfood { get; set; } = null!;

    public int Idcategory { get; set; }

    public double Price { get; set; }

    public virtual ICollection<Billinfo> Billinfos { get; set; } = new List<Billinfo>();

    public virtual Foodcategory IdcategoryNavigation { get; set; } = null!;
}
