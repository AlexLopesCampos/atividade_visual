﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Aula_24_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conecxão com banco para pedir dados 
            MySqlConnection conexao;
            MySqlCommand cmd;
            conexao = new MySqlConnection("server=localhost;database=pam;Uid=root;Pwd='';");
            try
            {
                conexao.Open();
                Console.WriteLine("Teste Foi");
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            string sql;
            sql = "select * from Dados";
            cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            { 
                Console.WriteLine("ID Usuario:"+ rdr["id"]+"\n");
                Console.WriteLine("Nome Usuario:" + rdr["nome"] + "\n");
            }
            rdr.Close();
            // para inserir dados
        Console.WriteLine("Inserir Dadosn\n\n");
            string nome;
            int doc;
            Console.WriteLine("Digite um nome\n");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Doc\n");
            doc = int.Parse(Console.ReadLine());

            sql = "insert into Dados(nome,doc) value(@nome, @doc)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@doc",doc);
            try
            {
                int linhaafetadas = cmd.ExecuteNonQuery();
                if( linhaafetadas == 0)
                {
                    throw new Exception("Nenhuma linha afetada.");
                }
                else
                {
                    Console.Write("linhaafetadas: {0}", linhaafetadas);
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            Paciente paciente = new Paciente();
            string opcao = "a";
            while (opcao.ToUpper() != "q");
            {
                Console.Clear();
                Console.WriteLine("1- Cadastar Paciente\n" + "2- Mostar Lista\n" + "3- Adicionar Paciente Prioritario" + "4- Atender Cliente\nDigite a letra Q para sair");
                
                opcao= Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        paciente.cadastrarPaciente();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        paciente.mostrarlista();
                        Console.Clear();
                        break;
                     case "3":
                        Console.Clear();
                        paciente.Prioridade();
                        Console.Clear();
                        break ;
                    case "4":
                        Console.Clear();
                        paciente.pacientesAtendidos();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
            
            }
        }
    }
}
