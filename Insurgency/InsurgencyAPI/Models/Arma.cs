namespace InsurgencyAPI.Models;

    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Dano { get; set; }
        public double Alcance { get; set; }
        public ArmaTipo Tipo { get; set; }
        public double Peso { get; set; }
    }

    public enum ArmaTipo
    {
        Rifle,
        Pistola,
        Espingarda
    }