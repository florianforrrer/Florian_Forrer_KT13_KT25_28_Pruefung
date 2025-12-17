namespace StundenplanApp.Data;

public class Stundenplan
{
    public int StundenplanId { get; set; }

    public string Datum { get; set; } = "";
    public string Uhrzeit { get; set; } = "";

    public int KlasseId { get; set; }
    public int LehrerId { get; set; }
    public int SchulzimmerId { get; set; }
}
