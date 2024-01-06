using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public virtual Propriedade Propriedade{get;set;}
    }
}