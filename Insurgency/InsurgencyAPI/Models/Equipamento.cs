namespace InsurgencyAPI.Models;

    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; } // O peso do equipamento pode influenciar na capacidade do inventário
        public EquipamentoTipo Tipo { get; set; } // Tipo de equipamento (Ex: Coletor, Mochila, etc.)
    }

    public enum EquipamentoTipo
    {
        Coletivo,
        Mochila,
        Acessorio
    }