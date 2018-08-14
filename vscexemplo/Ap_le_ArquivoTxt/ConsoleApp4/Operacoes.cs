using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Operacoes
    {
        Dados Meusdados;

        public Operacoes()
        {
            Meusdados = new Dados();
        }
        public void Inserir()
        {
            Aluno Meualuno;


            do
            {
                Meualuno = new Aluno(); 
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("       Cadastrar aluno na sua Agenda \n");
                Console.WriteLine("==================================================\n");


                Meualuno.Codigo = Geracodigo();
                Console.WriteLine("\n Código do aluno:{0}", Meualuno.Codigo);

                Console.Write("\n Digite o nome do aluno:");
                Meualuno.Nome = Console.ReadLine();

                Console.Write("\n Digite o telefone:");
                Meualuno.Telefone = Console.ReadLine();

                Console.Write("\n Digite o email:");
                Meualuno.Mail = Console.ReadLine();

                Meusdados.Inseriraluno(Meualuno);
                Console.WriteLine("\n");

                Console.WriteLine("================================================== \n");
                Console.WriteLine(" Deseja inseir outro registro na Agenda aperte  ");
                Console.WriteLine(" qualquer tecla ou (Esc) para voltar o Menu \n");
                Console.WriteLine("==================================================");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public void Pesquisar()
        {
            Console.Clear();

            Aluno Meualuno= new Aluno();

            string CodigoPesquisa;
            Console.WriteLine("pesquisa no cadastro de aluno");
            Console.WriteLine("=============================");

            Console.Write("codigo do aluno");
            CodigoPesquisa = Console.ReadLine();

            Meualuno = Meusdados.Pesquisaraluno(CodigoPesquisa);

            if (Meualuno != null)
            {
                Console.WriteLine("\n Nome..................:{0}", Meualuno.Nome);
                Console.WriteLine("\n telefone..............:{0}",Meualuno.Telefone);
                Console.WriteLine("\n mail..................:{0}", Meualuno.Mail);
            }
            else
            {
                Console.WriteLine("\naluno nao encontrado no cadastro!");
            }
            Console.ReadKey();
        }

        public void Alterar()
        {
            Aluno meualuno;
            Aluno meualunoalterado;

            string Codigopesquisa;
            Console.WriteLine("alteracao de dados do aluno meu cadastro");
            Console.WriteLine("=============================");

            Console.Write("codigo do aluno");
            Codigopesquisa = Console.ReadLine();

            meualuno = Meusdados.Pesquisaraluno(Codigopesquisa);

            if (meualuno != null)
            {
                Console.WriteLine("\nNome..................:{0}", meualuno.Nome);
                Console.WriteLine("\ntelefone..............:{0}", meualuno.Telefone);
                Console.WriteLine("\nmail..................:{0}", meualuno.Mail);

                Console.WriteLine("\naluno nao encontrado no cadastro!");
            }
            else
            {
                Console.WriteLine("\ndados de atualizacao:\n");
                meualunoalterado = new Aluno();
                meualunoalterado.Codigo = meualuno.Codigo;


                Console.WriteLine("\ntelefone..............");
                meualunoalterado.Telefone = Console.ReadLine();

                Meusdados.Alteraraluno(meualuno, meualunoalterado);
                Console.WriteLine("dados alterados");



            }
            Console.Read();
        }




        public void Listar()
        {
            Console.Clear();
            ArrayList Lista = Meusdados.Listaaluno();

            // listar alunos
            Console.Write("\n");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("      Alunos cadastrados na sua Agenda \n");
            Console.WriteLine("==================================================\n");

            foreach (Aluno x in Lista)
            {

                Console.WriteLine("Código do Aluno: {0}", x.Codigo);
                Console.WriteLine("\n Nome do aluno: {0}", x.Nome);
                Console.WriteLine(" telefone: {0}", x.Telefone);
                Console.WriteLine(" Email: {0}", x.Mail);
                Console.WriteLine("\n");
                Console.WriteLine("==================================================\n");
            }
            Console.ReadKey();
        }

        private string Geracodigo()
        {
            string result = " ";

            DateTime x = new DateTime();

            x = DateTime.Now;
         //   result += x.Date.ToString().Substring(0, 2);
         //   result += x.Date.ToString().Substring(3, 2);
          //  result += x.Date.ToString().Substring(8, 2);
            result += x.Second.ToString() + x.Minute.ToString() + x.Hour.ToString();

            return result;


        }

        public void Ordenar()
        {
            int registro;
            Console.WriteLine("ordenaco de registr do cadstro");
            Console.WriteLine("===========================");

            registro = Meusdados.Ordenaraluno();

            Console.WriteLine("total de registros:{0}", registro);

            Console.ReadKey();



        }




        public void Excluir()
        {

            Aluno meualuno;


            string codigopesquisa;
            Console.WriteLine("exclusao  do aluno meu cadastro");
            Console.WriteLine("=============================");

            Console.Write("codigo do aluno");
            codigopesquisa = Console.ReadLine();

            meualuno = Meusdados.Pesquisaraluno(codigopesquisa);

            if (meualuno != null)
            {
                Meusdados.ExcluirAluno(meualuno);

                Console.WriteLine("\naluno excluido!");
            }
            else
            {
                Console.WriteLine("\naluno nao enconterado!");

            }

        }

        public void Salvar()
        {

            int registro;
            Console.WriteLine(" Salvar de registr em arquivo");
            Console.WriteLine("===========================");

            registro = Meusdados.SalvarXML();

            Console.WriteLine(" Arquivo gerado com sucesso");
            Console.WriteLine("total de registros:{0}", registro);
            Console.WriteLine("Total de registro", registro);

            Console.ReadKey();
        }

        public void Abrir()
        {

            int Registro;
            Console.WriteLine(" Carregar registro de Dados do arquivo");
            Console.WriteLine("===========================");

            // registro = meusdados.SalvarXML();
            Registro = Meusdados.Abrir();

            Console.WriteLine(" Abrir XML carregado  com sucesso");
            Console.WriteLine("Total de registro {0}", Registro);

            Console.ReadKey();

        }


    }
}
