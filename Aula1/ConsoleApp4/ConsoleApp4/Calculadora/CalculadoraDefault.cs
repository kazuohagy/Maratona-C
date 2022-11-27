using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Calculadora
{
    public class CalculadoraDefault
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
}
