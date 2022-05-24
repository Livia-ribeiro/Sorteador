
namespace StartingProgram
{
    public static class StartingProgram
    {
        public static void Executar(string StartingProgram)
        {
            Console.WriteLine("Qual o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("____________________");
            Console.WriteLine("|                  |");
            Console.WriteLine("| Hello " + nomePessoa);
            Console.WriteLine("| Seu nome tem " + nomePessoa.Length + " letras");
            Console.WriteLine("|                  |");
            Console.WriteLine("--------------------");

            if (nomePessoa.Length > 7)
            {
                Console.WriteLine("Seu nome é muito grande!");
            }
            else if (nomePessoa.Length < 3)
            {
                Console.WriteLine("Seu nome é muito curto!");
            }

            Console.WriteLine("Qual sua idade?");
            string idadeInformada = Console.ReadLine();
            int idade = int.Parse(idadeInformada);

            Console.WriteLine("Você tem " + idadeInformada + " anos");

            if (idade >= 18)
            {
                Console.WriteLine("Permitido!");
            }
            else
            {
                Console.WriteLine("Negado!");
            }
        }
    }
}
