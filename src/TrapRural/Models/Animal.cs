using TrapRural.Enums;

namespace TrapRural.Models
{
    public class Animal
    {
        public int Id {get;set;}
        public string TipoAnimal{get;set;}
        public int QtdAnimais {get;set;}
        public Saude SaudeAnimal {get;set;}

        public string PropriedadeId{get;set;}
        public virtual PropriedadeModel Propriedade{get;set;} 
    }
}