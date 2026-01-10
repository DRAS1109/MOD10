using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestContactos
{
    public class Morada
    {
        // Rua
        public string Rua { get; set; }

        // Localidade
        private string localidade;

        public string Localidade
        {
            get { return localidade; }
            set
            {
                localidade = value.ToUpper();
            }
        }

        // Cod Postal
        private string codPostal;
        public string CodPostal
        {
            get { return codPostal; }
            set
            {
                if (IsValidCodPostal(value))
                    codPostal = value.Trim();

                else
                    codPostal = "0000-000";
            }
        }

        public static bool IsValidCodPostal(string value)
        {
            string pattern = @"^\d{4}-\d{3}$";

            return Regex.IsMatch(value, pattern);
        }

        public Morada(string _rua, string _localidade, string _codPostal)
        {
            Rua = _rua;
            Localidade = _localidade;
            CodPostal = _codPostal;
        }

        public Morada() : this("", "", "0000-000")
        {

        }
    }
}
