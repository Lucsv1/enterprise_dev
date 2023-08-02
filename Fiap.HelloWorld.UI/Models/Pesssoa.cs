using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models
{
    public class Pesssoa
    {
        private String _nome;
        private int _idade;
        private String Cpf { get; set; } 

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade 
        { 
            get { return _idade; } 
            set { _idade = value; } 
        }
    }
}
