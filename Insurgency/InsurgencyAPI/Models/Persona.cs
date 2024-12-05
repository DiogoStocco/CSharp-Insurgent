namespace InsurgencyAPI.Models;

    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; } // Relacionamento com a Classe
        public int InventarioId { get; set; }
        public Inventario Inventario { get; set; } // Relacionamento com o Inventário
    }