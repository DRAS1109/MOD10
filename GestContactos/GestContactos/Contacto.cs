using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestContactos
{
    public class Contacto
    {
        // ID
        private static int autoID;
        protected int ID;
        public int ValorID
        {
            get { return ID; }
        }


        //Nome
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (IsValidNome(value))
                    nome = value.Trim();

                else
                    nome = "Sem Nome";
            }
        }

        public static bool IsValidNome(string value)
        {
            bool valido = true;
            value = value.Trim();

            if (value.Length < 5 || value.Length > 120)
                valido = false;

            if (!value.Contains(" "))
                valido = false;

            return valido;
        }


        // Email
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value.Trim();

                else
                    email = "Inválido";
            }
        }

        public static bool IsValidEmail(string value)
        {
            bool valido = true;
            value = value.Trim();

            try
            { MailAddress Mail = new MailAddress(value); }

            catch (Exception)
            { valido = false; }

            return valido;
        }


        //Telefone
        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (IsValidTelefone(value))
                    telefone = value.Trim();

                else
                    telefone = "Inválido";
            }
        }

        public static bool IsValidTelefone(string value)
        {
            // Regex explicada abaixo
            string pattern = @"^\+?\s*(?:\(\d+\)\s*)?[0-9]+(?:[ -]?[0-9]+)*$";
            return Regex.IsMatch(value.Trim(), pattern);
        }

        //Morada
        public Morada MoradaAtual { get; set; }

        //Nome Abreviado
        public static string NomeAbreviado(string value)
        {
            value = value.Trim();

            string[] palavras = value.Split(' ');

            string Apelido, primeiroNome;

            Apelido = palavras[palavras.Length - 1].ToUpper();
            primeiroNome = char.ToUpper(palavras[0][0]) + palavras[0].ToLower().Substring(1);

            string nomeAbreviado = $"{Apelido}, {primeiroNome}";

            return nomeAbreviado;
        }

        public Contacto(string _nome, string _email, string _telefone, Morada _MoradaAtual)
        {
            Nome = _nome;
            Email = _email;
            Telefone = _telefone;
            ID = ++autoID;
            MoradaAtual = _MoradaAtual;
        }

        public Contacto(string _nome) : this(_nome, "", "", new Morada())
        {

        }
    }
}
