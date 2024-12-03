namespace InsurgencyAPI.Models;

public class Card
{

    public Card()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    
    public string? Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public DateTime CriadoEm { get; set; }
    public Tipo Tipo { get; set; }
    public int TipoId { get; set; }

}