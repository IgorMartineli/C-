using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Paciente : Pessoa
    {
        public String CPF { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }
        public String DTNasc { get; set; }

    }
}
