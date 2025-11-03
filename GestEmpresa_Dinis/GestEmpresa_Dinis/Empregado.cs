using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
            get { return ID; }
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

        private string nome;
        /// <summary>
        /// Nome do empregado
        /// </summary>
        public string Nome 
        {
            get { return nome; }
            set
            {
                if (IsValidNome(value))
                    nome = value.Trim(); //Retira os espaços no inicio e no final do texto

                else
                    nome = "Sem Nome";
            }
        }

        /// <summary>
        /// Data de nascimento do empregado
        /// </summary>
        public DateTime DatNasc { get; set; }

        /// <summary>
        /// Morada do empregado
        /// </summary>
        public Morada MoradaAtual { get; set; }

        /// <summary>
        /// Campo privado email
        /// </summary>
        private string eMail;

        /// <summary>
        /// eMail do empregado. Apenas é permitido atualizar um eMail valido
        /// </summary>
        public string EMail
        {
            get { return eMail; }
            set
            {
                if (IsValidEmail(value))
                    eMail = value;
                else
                    eMail = "";
            }
        }

        /// <summary>
        /// Campo privado Telefone
        /// </summary>
        public string telefone;

        public string Telefone
        { 
            get { return telefone; }
            set
            {
                if (IsValidTelefone(value))
                    telefone = value.Trim();
                else
                    telefone = "";
            }
        }

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
            Telefone = telefone; //Inacabado 
            ID = ++autoID;
        }

        /// <summary>
        /// Construtor para criar um empregado com apenas o nome
        /// </summary>
        /// <param name="nome"></param>

        public Empregado(string nome) : this(nome, new DateTime(), "", "", new Morada())
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
            //Retira os espaços no inicio e no final do texto
            string[] palavras = nome.Trim().Split(' ');

            string apelido, primeiroNome;
            string nomeAbreviado = "";
            // O nome deve ter pelo menos 2 palavras
            if (palavras.Length > 1)
            {
                // Último elemento do vetor em maiusculas
                apelido = palavras[palavras.Length - 1].ToUpper();

                // Primeiro elemento do vetor com capitalize
                // palavras[0][0] representa a primeira letra da primeira palavra. Devolve um caractere
                // palavras[0][0].ToUpper() não é valido, porque não se trata de uma string
                // char.ToUpper() converte um caractere para maiuscula
                // Substring(1), devolve a substring do primeiro nome a partir da posição 1

                primeiroNome = char.ToUpper(palavras[0][0]) + palavras[0].ToLower().Substring(1);

                nomeAbreviado = string.Format("{0}, {1}", apelido, primeiroNome);
            }

            return nomeAbreviado;
        }

        /// <summary>
        /// Método para verificar se o nome tem pelo menos um espaço no meio 
        /// e se tem entre 7 a 150 caracteres
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool IsValidNome(string nome)
        {
            bool valido = true;
            nome = nome.Trim(); //Tira os espaços do inicio e do final

            //Se tiver menos de 7 caracteres e mais de 150 retorna false
            if (nome.Length < 7 || nome.Length > 150)
                valido = false;

            // Pelo menos duas palavras
            if (!nome.Contains(" ")) //Se não contiver um espaço retorna false
                valido = false;

            return valido;
        }

        /// <summary>
        /// Metodo para verificar o email, caso seja válido retorna o email, se não for retorna ""
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            bool valido = true;
            email = email.Trim();
            try
            {
                MailAddress mail = new MailAddress(email);
                valido = false;
            }
            catch (Exception)
            {
                 valido = false;
            }
            return valido;
        }

        /// <summary>
        /// Verifica se um telefone tem um formato válido:
        /// - opcional "+" no início
        /// - opcional código de país entre parênteses (ex: (351))
        /// - resto composto apenas por dígitos, espaços ou traços, em grupos válidos
        /// </summary>
        public bool IsValidTelefone(string telefone)
        {
            // Regex explicada abaixo
            string pattern = @"^\+?\s*(?:\(\d+\)\s*)?[0-9]+(?:[ -]?[0-9]+)*$";
            return Regex.IsMatch(telefone.Trim(), pattern);
        }
    }
}
