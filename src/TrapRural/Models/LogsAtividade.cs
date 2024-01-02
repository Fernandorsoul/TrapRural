

namespace TrapRural.Models
{
    public class LogsAtividade
    {
        public int Id{get;set;}
        public string Descricao{get;set;}
        public DateTime DataHora { get;set;}

        public string UsuarioId{get;set;}
        public virtual Usuario Usuario{get;set;}
    }
}