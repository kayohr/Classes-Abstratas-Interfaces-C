using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.interfaces
{
    public interface ICalculadora
    {
        int Somar(int num, int num2);
        int Subtrair(int num, int num2);
        int Multiplicar(int num, int num2);
        int Dividir(int num, int num2);
    }
}