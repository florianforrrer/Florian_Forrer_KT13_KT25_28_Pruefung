using System;
using System.Collections.Generic;

namespace StundenplanApp.Data;

public partial class Schulzimmer
{
    public int SchulzimmerId { get; set; }

    public string Nummer { get; set; } = null!;

    public virtual ICollection<Stundenplan> Stundenplans { get; set; } = new List<Stundenplan>();
}
