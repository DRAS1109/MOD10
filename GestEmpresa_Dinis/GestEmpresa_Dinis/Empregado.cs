using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Dinis
{
    public class Empregado
    {
        /* Pretendemos uma numeração automática no ID do empregado inicialmente é atribuido o valor zero
        Apenas o empregado tem acesso
        Estático para podermos atribuir o valor de ID de cada Empregado de frma automartica */
        private static int autoID;

        /* ID do empregado
        protected: APENAS o programador e o analista vão ter acesso */
        protected int ID;

        /* Campos da DataGridView
        Propriedades de emprego que vão surgir na DataGridView */

        /// <summary>
        /// 1º Campo: Valor do Id
        /// </summary>
        public int ValorID
        { 
            get { return ID;} 
        }

        /// <summary>
        /// 2º campo: Nome Abreviado
        /// </summary>
        public string NomeAbreviado
        {
            get { return GetNomeAbreviado(Nome); }
        }

        /// <summary>
        /// 3º Campo: Localidade
        /// </summary>
        public string Localidade
        {
            get { return MoradaAtual.Localidade; }
        }

        /// <summary>
        /// 4º Campo: Cargo
        /// </summary>
        public string Cargo
        {
            get { return GetCargo(); }
        }

        // Propriedades
        private string Nome { get; set; }
        public DateTime DatNasc { get; set; }
        public Morada MoradaAtual { get; set; }
        private string eMail { get; set; }
        public string Telefone { get; set; }

        /// <summary>
        /// Construtor para criar um empregado com todas as propriedades do objeto
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="datNasc"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="moradaAtual"></param>
        public Empregado(string nome, DateTime datNasc, string email, string telefone, Morada moradaAtual)
        {
            Nome = nome;
            DatNasc = datNasc;
            MoradaAtual = moradaAtual;
            eMail = email;
            Telefone = telefone;
            ID = ++autoID;
        }

        /// <summary>
        /// Construtor para criar um empregado com apenas o nome
        /// </summary>
        /// <param name="nome"></param>

        public Empregado(string nome): this(nome, new DateTime(), "", "", new Morada())
        {

        }

        /// <summary>
        /// Devolve o cargo do empregado
        /// </summary>
        /// <returns></returns>
        public virtual string GetCargo()
        {
            return "Empregado";
        }

        /// <summary>
        /// Devolve o nome do formato: APELIDO, Nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns> Nome Abreviado </returns>
        public static string GetNomeAbreviado(string nome)
        {
            string nomeAbreviado = "";

            return nomeAbreviado;
        }
    }
}
