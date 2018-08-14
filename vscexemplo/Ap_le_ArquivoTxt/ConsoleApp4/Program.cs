using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Operacoes Minhasoperacoes = new Operacoes();

            int Opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("==================================================\n");
                Console.WriteLine("Agenda de Contatos de aluno da Pucminas Contagem\n");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("                      Menu\n");

                Console.WriteLine("\t\t 1 - inserir");
                Console.WriteLine("\t\t 2 - alterar");
                Console.WriteLine("\t\t 3 - excluir");
                Console.WriteLine("\t\t 4 - pesquisar ");
                Console.WriteLine("\t\t 5 - listar");
                Console.WriteLine("\t\t 6 - ordenar");
                Console.WriteLine("\t\t 7 - salvar dados em arquivo");
                Console.WriteLine("\t\t 8 - carregar dados do arquivo");
                Console.WriteLine("\t\t 9 - sair");
                Console.Write("\n Digite a opção desejada para acessar o menu: ");

                //Console.WriteLine("opcao");
                Opcao = int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case 1:
                        Minhasoperacoes.Inserir();
                        break;

                    case 2:
                        Minhasoperacoes.Alterar();
                        break;

                    case 3:
                        Minhasoperacoes.Excluir();
                        break;

                    case 4:
                        Minhasoperacoes.Pesquisar();
                        break;

                    case 5:
                        Minhasoperacoes.Listar();
                        break;

                    case 6:
                        Minhasoperacoes.Ordenar();
                        break;

                    case 7:

                        Minhasoperacoes.Salvar();
                        break;

                    case 8:
                        Minhasoperacoes.Abrir();

                        break;

                    case 9:
                        Console.Write("\n sair do sistema!!");
                        Thread.Sleep(2000);
                        break;
                    default:

                        Console.Write("\nopcao invalida!!");
                        Thread.Sleep(2000);
                        break;


                
               

            }
            } while (Opcao != 9);
        }
    }
}

