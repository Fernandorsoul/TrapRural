using TrapRural.Enums;

namespace TrapRural.Models
{
    public class Cultura
    {
        public string Id{get;set;}
        public TipoCultura Tipo {get;set;}
        public double QtdPlantada {get;set;}
        public DateTime DataPlantio{get;set;}
        public DateTime DataColheita{get;set;}
        
        public string  PropriedadeId{get;set;}
        public virtual PropriedadeModel Propriedade {get;set;}
    }
}