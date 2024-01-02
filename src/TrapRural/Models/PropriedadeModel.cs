namespace TrapRural.Models
{
    public class PropriedadeModel
    {
        public int Id{get;set;}
        public string? NomePropriedade{get;set;}
        public double? AreaPropriedade{get;set;}
        public string? Localizacao{get;set;}
        public string? ContatoProp{get;set;}

        public List<Cultura> Culturas {get;set;}
        public List<Animal> Animais {get;set;}
        public List<Manutencao> Manutencoes {get;set;}
    }
}