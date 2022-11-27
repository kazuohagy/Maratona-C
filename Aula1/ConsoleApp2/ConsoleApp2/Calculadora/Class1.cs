using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Calculadora
{
    public class Class1
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        
        public void CalculadoraPadrao(int n1, int n2)
        {
            Numero1 = n1;
            Numero2 = n2;
        }
        public int Somar()
        {
            return Numero1 + Numero2;
        }
        public int Subtrair()
        {
            return Numero1 - Numero2;
        }
        public int Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public int Dividir()
        {
            return Numero1 / Numero2;
        }
        
    }
}
