namespace InsurgencyAPI.Models;

    public class Classe
    {
        // Campo privado para armazenar a vida
        private int _vida;
        // Propriedade Vida com restrição de valor
        public int Vida
        {
            get { return _vida; }
            set
            {
                // Garante que a vida esteja entre 0 e 10
                if (value < 0)
                    _vida = 0;
                else if (value > 10)
                    _vida = 10;
                else
                    _vida = value;
            }
        }
        // Construtor para inicializar a vida com 10
        public Classe()
        {
            _vida = 10; // Valor inicial da vida
        }
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string Descricao { get; set; } // Descrição das habilidades da classe
        public List<Equipamento> EquipamentosPermitidos { get; set; } // Equipamentos permitidos
        public List<Arma> ArmasPermitidas { get; set; } // Armas permitidas
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
