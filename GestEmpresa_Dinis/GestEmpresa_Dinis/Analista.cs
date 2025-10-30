using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Dinis
{
    public class Analista: Empregado
    {
        public string Projeto { get; set; }

        public Analista(string projeto, string nome, DateTime datNasc, string email, int telefone, Morada moradaAtual, string rua, string localidade, string codPostal): base(nome, datNasc, email, telefone, moradaAtual)
        {
            Projeto = projeto;
        }

        public Analista(string nome): base(nome) 
        {
            Projeto = "Por definir";
        }
    }
}
