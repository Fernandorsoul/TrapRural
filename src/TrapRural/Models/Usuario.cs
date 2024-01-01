using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrapRural.Models
{
    public class Usuario
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}

        public List<LogsAtividade> Logs{get;set;}
    }
}