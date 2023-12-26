using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class ALuno : Pessoa
    {
        public ALuno(string name) : base(name)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos e sou aluno nota {Nota}");
          
        }
    }
}