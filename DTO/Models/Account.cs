using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Account
{
    public string Username { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Type { get; set; }
}
