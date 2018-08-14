using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void Inseriraluno(Aluno x)
        {
            Cadastro.Add(x);
        }

        public ArrayList Listaaluno()
        {

            return Cadastro;

        }

        public Aluno Pesquisaraluno(string Cod)
        {
            foreach (Aluno x in Cadastro)
  
            {
                if (x.Codigo == Cod)
                {
                    return x;
                }
            }
            return null;
        }

        public void Alteraraluno(Aluno x, Aluno y)
        {
            int posicao;
            posicao = Cadastro.IndexOf(x);
            Cadastro.Remove(x);
            Cadastro.Insert(posicao, y);
        }
        public void ExcluirAluno(Aluno x)
        {
            Cadastro.Remove(x);

        }
        public int Ordenaraluno()
        {
            Cadastro.Sort(new Minhaordenacao());

            return Cadastro.Count;

        }


        public class Minhaordenacao : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
            }
        }

        public int SalvarXML()
        {

            TextWriter Meuwriter = new StreamWriter(@"e:\Temp\ArquivosAlunos.xml");

            Aluno[] ListaAlunoVetor = ( Aluno[])Cadastro.ToArray( typeof(Aluno) ) ;

            XmlSerializer Serelização = new XmlSerializer(ListaAlunoVetor.GetType());

            Serelização.Serialize(Meuwriter, ListaAlunoVetor);

            Meuwriter.Close();

            return Cadastro.Count;
          
        }

        public int Abrir()
        {
            FileStream arquivo = new FileStream(@"e:\Temp\ArquivosAlunos.xml", FileMode.Open);

            Aluno[] cadastroVetor = Cadastro.ToArray( typeof(Aluno) ) as Aluno[];

            XmlSerializer serializer = new XmlSerializer(cadastroVetor.GetType());

            cadastroVetor = serializer.Deserialize(arquivo) as Aluno[];

            arquivo.Close();
            Cadastro.Clear();
            Cadastro.AddRange(cadastroVetor);

            return Cadastro.Count;

                     
            
        }
    }
}
