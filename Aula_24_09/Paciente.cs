using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Aula_24_09
{
    internal class Paciente
    {
        public Paciente[] pacie;
        public string nome;
        public string cpf;
        public string endereco;
        public int idade;
        public string telefone;
        public int registro;
        public bool propriedade;
        public int lista = 0;
        public int prioridade = 0;

        public Paciente(string nome = "", string cpf = "", string endereco = "", int idade = 0, string telefone = "", int registro = 0)
        {
            pacie = new Paciente[11];
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.idade = idade;
            this.telefone = telefone;
            this.registro = registro;
        }


        public void cadastrarPaciente()
        {
            if (lista < 10)
            {
                Console.WriteLine("Digite o nome:", nome);
                nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF:", cpf);
                cpf = Console.ReadLine();
                Console.WriteLine("Digite o Endereço", endereco);
                endereco = Console.ReadLine();
                Console.WriteLine("Digite a Idade", idade);
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Telefone:", telefone);
                telefone = Console.ReadLine();
                Console.WriteLine("Coloque o Numero de Registro", registro);
                registro = int.Parse(Console.ReadLine());
                Paciente paciente = new Paciente(nome, cpf, endereco, idade, telefone, registro);
                pacie[lista] = paciente;
                lista++;
                Console.WriteLine("Paciente Cadastrado");

            }
            else
            {
                Console.WriteLine("lista de Pacientes Completa");
            }
        }
        public void mostrarlista()
        {
            if (lista > 0)
            {
                for (int i = 0; i < lista; i++)
                {
                    if (pacie[i] != null)
                    {
                        Console.Write($"Paciente {i + 1}");
                        Console.WriteLine($"Nome:{pacie[i].nome}");
                        Console.WriteLine($"CPF:{pacie[i]}");
                        Console.WriteLine($"Endereço:{pacie[i]}");
                        Console.WriteLine($"Idade:{pacie[i]}");
                        Console.WriteLine($"Telefone:{pacie[i]}");
                        Console.WriteLine($"Registro:{pacie[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia");
            }
            Console.ReadKey();
        }
        public void Prioridade()
        {
            if (lista <= 10)
            {
                Console.WriteLine("Digite o nome:", nome);
                nome = Console.ReadLine();
                Console.WriteLine("Digite o CPF:", cpf);
                cpf = Console.ReadLine();
                Console.WriteLine("Digite o Endereço", endereco);
                endereco = Console.ReadLine();
                Console.WriteLine("Digite a Idade", idade);
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Telefone:", telefone);
                telefone = Console.ReadLine();
                Console.WriteLine("Coloque o Numero de Registro", registro);
                registro = int.Parse(Console.ReadLine());
                Paciente paciprioritario = new Paciente(nome, cpf, endereco, idade, telefone, registro);

                for (int i = lista - 1; i >= prioridade; i--)
                {
                    pacie[i + 1] = pacie[i];
                }
                pacie[prioridade] = paciprioritario;
                prioridade++;
                lista++;

            }
            Console.WriteLine("Paciente Com Prioridade listado com Sucesso\n" + "\n\t\t\t\t\tAperte QualQuer Tecla para Voltar\n" + "\n\t\t\t\tou\n" + "\n\t\tAperte Q para sair" + "");
            Console.ReadKey();
        }
        public void pacientesAtendidos()
        {
            Paciente PacieAtendidos = pacie[0];
            if (lista > 0)
            {
                for (int i = 1; i < lista; i++)
                {
                    pacie[i - 1] = pacie[i];
                }
                pacie[lista - 1] = null;
                lista--;
                Console.WriteLine($"O Paciente {PacieAtendidos.nome} foi atendidos");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não a Pacientes");
                Console.ReadKey();
            }
        }
    }
}
