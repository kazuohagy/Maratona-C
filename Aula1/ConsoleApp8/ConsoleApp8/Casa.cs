﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Casa
    {
        public Casa() { }
        public Casa(int tamanho, string cor) {
            Tamanho= tamanho;
            Cor= cor;
        }  
        public Casa(int tamanho, string cor,int qtdPortas, int qtdJanelas) {
            Tamanho= tamanho;
            Cor= cor;
            QuantidadeDePortas= qtdPortas;
            QuantidadeDeJanelas= qtdJanelas;
        }
        public int Tamanho { get; set; }
        public string Cor { get; set; }

        public int QuantidadeDePortas { get; set; }
        public int QuantidadeDeJanelas { get; set; }

        public void VenderCasa()
        {
            Console.WriteLine("A casa foi alugada :D");
        }
    }
}
