using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Dinis
{
    public class Programador: Empregado
    {
        public string Especialidade { get; set; }

        public Programador(string especialidade, string nome, DateTime datNasc, string email, string telefone, Morada moradaAtual) : base(nome, datNasc, email, telefone, moradaAtual)
        {
            Especialidade = especialidade;
        }

        public Programador(string nome) : base(nome)
        {
            Especialidade = "Por identificar";
        }
    }
}
