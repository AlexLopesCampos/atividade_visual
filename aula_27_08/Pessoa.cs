using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_27_08
{
    internal class Pessoa
    {
        public int ID;
        public string nome;
        public string telefone;
        public string email;
        public string cpf;
        public void cadastrar()
        {
              Console.WriteLine("digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu Email");
            email = Console.ReadLine();
            Console.WriteLine("digite seu telefone");
            telefone = Console.ReadLine();
            Console.WriteLine("Digite o ID");
            //Int.Parse serve para que um string ou uma variavel de texto mude para uma variavel de numeros inteiros
            //O mesmo vale para double.parse para mudar uma variavel de texto em uma numero em decimal
            ID = int.Parse(Console.ReadLine());
            //para o sistema nao desligar quando as informação colocadas
            Console.ReadKey();
        }

        public void mostradados()
        {
            //{0} onde ser imprimido oque esta na variavel nome
           Console.WriteLine("Nome:{0}",nome);
            //+email apena outro metodo de colocar oque esta na variavel para ser imprimida 
            Console.WriteLine("E-mail:"+email);
            Console.WriteLine("Telefone{0}:",telefone);
            Console.WriteLine("ID:{0}",ID);
        }
    }
}
