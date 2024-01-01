using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrapRural.Models
{
    public class Manutencao
    {
        public int Id{get;set;}
        public string DescricaoDoProblema{get;set;}
        public DateTime DataInicial{get;set;}
        public DateTime DataFinal {get;set;}
        public double Custo{get;set;}

        public string PropriedadeId{get;set;}
        public virtual Propriedade Propriedade{get;set;}
    }
}