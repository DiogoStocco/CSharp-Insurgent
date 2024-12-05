namespace InsurgencyAPI.Models;

    public class Inventario
    {
        public int Id { get; set; }
        public int Capacidade { get; set; } // Capacidade máxima de itens que o personagem pode carregar
        public List<Item> Itens { get; set; } // Lista de itens que o personagem possui
        public List<Equipamento> Equipamentos { get; set; } // Lista de equipamentos no inventário
    }