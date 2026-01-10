using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Dinis
{
    static class Empresa
    {
        // BindingList de empregados para guardar os empregados e vincular a lista com a DataGridView no ambiente grafico
        public static BindingList<Empregado> emp = new BindingList<Empregado>();

        // Configurações
        public static string appNome = "GestEmpresa";
        public static string appVer = "v2.0 Beta";

        // Lista de tipos de empregados (cargos)
        public static List<string> cargos = new List<string> { "Empregado", "Programador", "Analista"};

        public const int CARGO_EMPREGADO = 0;
        public const int CARGO_PROGRAMADOR = 1;
        public const int CARGO_ANALISTA = 2;

        static Empresa()
        {
            emp.Add(new Programador("Programador de CeXarp", "Denis Tche", new DateTime(1984, 9, 11), "DenisProGramador@gmail.com", "96010203",
                new Morada("Rua Secundaria", "Onde", "3540-293")));

            emp.Add(new Programador("Programador em Paiton", "Maria do Codigo", new DateTime(1737, 3, 24), "MariaDoCodigo@gmail.com", "",
                new Morada("Rua Terciaria", "", "3270-328")));

            emp.Add(new Programador("Joaquim"));
        }
    }
}
