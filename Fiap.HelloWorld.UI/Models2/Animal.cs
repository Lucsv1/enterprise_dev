using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Models2
{
    internal class Animal : Cachorro
    {
        private String _Genero;
        private int _Idade;
        private double _Peso;

        public String Genero { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }


    }
}
