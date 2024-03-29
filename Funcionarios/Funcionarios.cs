using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Funcionario
    {
        //0- Fincionario 0,1
        //1- Diretor 1
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario * 2;
            else
                return Salario * 0.10;
        }
        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
    }
}