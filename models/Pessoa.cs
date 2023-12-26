using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Pessoa
    {

        public Pessoa()
        {   
        }
        public Pessoa(string nome)
        {   
            Nome = nome;
        }

        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }

    }
}