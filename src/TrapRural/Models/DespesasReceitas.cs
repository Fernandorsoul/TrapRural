using TrapRural.Enums;

namespace TrapRural.Models
{
    public class DespesasReceitas
    {
        public int Id{get;set;}
        public Tipo Tipo {get;set;}
        public string Descricao{get;set;}
        public double Valor{get;set;}
        public DateTime Data{get;set;}

        public string PropriedadeId{get;set;}
        public virtual PropriedadeModel Propriedade{get;set;}
    }
}