using System;
using System.Collections.Generic;

namespace StundenplanApp.Data;

public partial class Lehrer
{
    public int LehrerId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Stundenplan> Stundenplans { get; set; } = new List<Stundenplan>();
}
