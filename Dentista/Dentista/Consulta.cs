using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Consulta
    {
        public int IDConsulta{ get; set; }

        public int IDdentista { get; set; }
        public int IDPaciente { get; set; }
        public String Motivo { get; set; }
        public String Receita { get; set; }
        public String Diagnostico { get; set; }
        public String MotivoR { get; set; }
        public DateTime DTconsulta { get; set; }
        public DateTime DTretorno { get; set; }
    }
}
