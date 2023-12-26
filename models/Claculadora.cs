using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.interfaces;

namespace ExemploPOO.models
{
    public class Claculadora : ICalculadora
    {
        public int Dividir(int num, int num2)
        {
            return num / num2;
        }

        public int Multiplicar(int num, int num2)
        {
            return num * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }


        public int Subtrair(int num, int num2)
        {
            return num - num2;
        }
    }
}