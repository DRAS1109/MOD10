using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GestEmpresa_Dinis
{
    public class Morada
    {
        /// <summary>
        /// Criar constante para código postal por defeito
        /// </summary>

        public const string DefaultCodPostal = "0000-000";

        /// <summary>
        /// Rua da morada
        /// </summary>
        public string Rua { get; set; }
        
        /// <summary>
        /// Campo privado Localidade da morada
        /// </summary>
        public string localidade { get; set; }

        /// <summary>
        /// A localidade é atualizada sempre com letras Maiusculas
        /// </summary>
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value.ToUpper(); }
        }
        
        /// <summary>
        /// Codigo Postal da morada
        /// </summary>
        public string codPostal { get; set; }

        /// <summary>
        /// Código Postal com o formato 0000-000
        /// </summary>
        public string CodPostal
        {
            get 
            {  
                return codPostal; 
            }

            set 
            {  
                if (IsValidCodPostal(value))
                    codPostal = value;

                else
                    codPostal = DefaultCodPostal; 
            }
        }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rua">Rua</param>
        /// <param name="localidade">Localidade</param>
        /// <param name="codPostal">Codigo Postal</param>

        public Morada(string rua, string localidade, string codPostal)
            {
            Rua = rua;
            Localidade = localidade;
            CodPostal = codPostal;
        }

        /// <summary>
        /// Construtor com os pârametros essenciais na criação do objeto
        /// </summary>
        /// <param name="codPostal">Código Postal</param>
        public Morada(string codPostal): this ("", "", codPostal)
        {

        }

        /// <summary>
        /// Construtor com parametros por omissões
        /// </summary>
        public Morada(): this("", "", "0000-000") 
        { 

        }

        /// <summary>
        /// Valida se o código postal está no formato "0000-000"
        /// O metodo é estatico porque a função não depende das caracteristicas do objeto.
        /// </summary>
        /// <param name="_codPostal"></param>
        /// <returns>Devolve true se o codigo postal é válido, caso contrario devolve false</returns>
        public static bool IsValidCodPostal(string _codPostal)
        {
            // https://regex101.com/
            // https://regexr.com/
            // https://regexstorm.net/

            string pattern = @"^\d{4}-\d{3}$";

            return Regex.IsMatch(_codPostal, pattern);
        }
    }
}
