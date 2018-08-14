using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Aluno
    {
        private string _Codigo;

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }


        private string _Nome;

        public string Nome

        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Telefone;


        public string Telefone

        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        private string _Mail;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        public Aluno()
        {
            _Codigo = (" ");
            _Nome = (" ");
            _Telefone = (" ");
            _Mail = (" ");
        }
    }
}
