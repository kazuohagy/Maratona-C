using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public struct Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string TipoEnum { get; set; }
        public TipoRuaEnum TipoRua { get; set; }
    }
}
