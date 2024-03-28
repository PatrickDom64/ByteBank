using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank{
    class Program{
        static void Main(string[] args) {
            
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao(); 
            
            //Funcionario
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.CPF = "546.975.157-10";
            carlos.Salario = 2400;

            Console.WriteLine(carlos.GetBonificacao());
            Console.ReadLine();

            //Diretora
            Funcionario roberta = new Funcionario(2);

            roberta.Nome = "Roberta";
            roberta.CPF = "548.645.852-90";
            roberta.Salario = 9000;

            Console.WriteLine(roberta.GetBonificacao());
            Console.ReadLine();

        }
    }
}