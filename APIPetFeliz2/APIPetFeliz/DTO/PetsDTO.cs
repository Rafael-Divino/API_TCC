﻿namespace APIPetFeliz.DTO
{
    public class PetsDTO
    {
        public int Id_Pet { get; set; }
        public string Nome_Pet { get; set; }
        public string Sexo_Pet { get; set; }
        public string Descricao_Pet { get; set; }
        public string Idade_Pet { get; set; }
        public string Foto_Pet { get; set; }
        public string Porte_Pet { get; set; }
        public string Status_Pet { get; set; }
        public int Cod_Usuario { get; set; }
        public AnimalDTO Animal { get; set; }
        public EspecieDTO Especie { get; set; }
        public RacaDTO Raca { get; set; }
        public VacinaDTO Vacina { get; set; }
    }
}
