using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Professor : Pessoa
    {
        public Professor()
        {    
        }
        public Professor(string nome) : base(nome)
        {   
        }

        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos, e ganho {Salario}");
          
        }
    }
}