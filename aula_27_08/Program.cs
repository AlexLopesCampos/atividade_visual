using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace aula_27_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa Funcionario1 = new Pessoa();
            Pessoa Funcionario2 = new Pessoa();
            Pessoa Funcionario3 = new Pessoa();
            Gerente g1 = new Gerente();
            
         

            Funcionario1.cadastrar();
            

            Funcionario1.mostradados();
            Console.ReadKey();



        }
    }
}
