namespace GestContactos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        /* Gestor de Contactos
        Objetivo: Criar duas classes — Contacto e Endereco — que permitam representar contactos simples para uma aplicação de agenda.


        Contacto deve ter:
        ID automático (estático, começa em 0 e incrementa-se quando um novo contacto é criado).
        Nome (com validação: pelo menos duas palavras; tamanho mínimo 5 e máximo 120).
        Email (só aceitar e-mails válidos; se inválido guardar string vazia).
        Telefone (validar formato semelhante ao do teu código: opcional “+”, opcionais parênteses para código do país, dígitos, espaços/traços permitidos).
        Propriedades calculadas para: NomeAbreviado (último apelido em maiúsculas, primeiro nome capitalizado) e Localidade (delegada ao objeto Endereco).
        Construtor completo e construtor apenas com Nome.


        Endereco deve ter:
        Rua, Localidade (armazenada sempre em maiúsculas), CodPostal com formato 0000-000. Um construtor por omissão que use um código postal por defeito.
        Método estático IsValidCodPostal que valida o formato.
        Validações exigidas
        Reproduzir regras de validação descritas acima (tamanho do nome, presença de espaço, validação de email, telefone e código postal).
        IDs não podem repetir (usar campo estático para atribuição).
         */
    }
}