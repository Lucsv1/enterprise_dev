using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    public class Aluno : Pesssoa
    {
        public DateTime DtMatricula { get; set; }

        public Boolean Ativo { get; set; }

    }
}
