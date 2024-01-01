using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrapRural.Models
{
    public class LogsAtividade
    {
        public int Id{get;set;}
        public string Descricao{get;set;}
        public DateTime DataHora

        public string UsuarioId{get;set;}
        public virtual Usuario Usuario{get;set;}
    }
}