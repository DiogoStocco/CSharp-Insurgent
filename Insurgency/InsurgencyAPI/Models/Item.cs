namespace InsurgencyAPI.Models;

    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoItem Tipo { get; set; } // Enum que indica o tipo de item (Ex: Medicamento, Granado, Equipamento)
    }

    public enum TipoItem
    {
        Medicamento,
        Equipamento,
        Arma,
        Acessorio
    }