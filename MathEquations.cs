
namespace MathEquations
{
    public static class MathEquations
    {
        public static void Executar(string mathEquations)
        {
            int matematicaSoma = 200 + 59;
            Console.WriteLine(matematicaSoma);

            int macasDivididas = 35 / 3;
            int restanteMacas = 35 % 3;
            Console.WriteLine($"Cada filha recebeu {macasDivididas} maçãs");
            Console.WriteLine($"A mãe ficou com {restanteMacas} maçãs");

            decimal divisaoMacas = 35.0m / 3;
            Console.WriteLine($"Cada filha recebeu {divisaoMacas} maçãs");

            int frutas = 35;
            int filhas = 3;
            decimal resultado = (decimal)frutas / filhas;
            Console.WriteLine($"Cada filha irá receber {resultado} maçãs");

            Console.WriteLine("Digite o primeiro valor:");
            string valor1Informado = Console.ReadLine();
            int firstValue = int.Parse(valor1Informado);

            Console.WriteLine("Digite o segundo valor:");
            string valor2Informado = Console.ReadLine();
            int secondValue = int.Parse(valor2Informado);

            Console.WriteLine("Escolha a operação:");

            Console.WriteLine("Adição");
            Console.WriteLine("Subtração");
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Divisão");
            Console.WriteLine("Resto");

            string equacao = Console.ReadLine();

            if (equacao == "Adição")
            {
                int resultSoma = firstValue + secondValue;
                Console.WriteLine($"O resultado da soma de {firstValue} com {secondValue} é {resultSoma}");
            }
            else if (equacao == "Subtração")
            {
                int resultSubtracao = firstValue - secondValue;
                Console.WriteLine($"O resultado da subtração de {firstValue} menos {secondValue} é {resultSubtracao}");

            }
            else if (equacao == "Multiplicação")
            {
                int resultMultiplicacao = firstValue * secondValue;
                Console.WriteLine($"O resultado da multiplicação de {firstValue} por {secondValue} é {resultMultiplicacao}");
            }
            else if (equacao == "Resto")
            {
                int resultRestante = firstValue % secondValue;
                Console.WriteLine($"O que resta de {firstValue} quando dividido por {secondValue} é {resultRestante}");
            }
            else if (equacao == "Divisão")
            {
                int resultDivisao = firstValue / secondValue;
                Console.WriteLine($"O resultado da divisão de {firstValue} por {secondValue} é {resultDivisao}");
            }

            Console.ReadKey();

            decimal Temperatura = 94;
            decimal Celsius = (Temperatura - 32) * (5 / 9m);
            Console.WriteLine(Celsius);
            //Console.WriteLine("Digite o primeiro número:");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número:");
            //int secondNumber = int.Parse(Console.ReadLine());

            //int resultEquation = firstNumber / secondNumber;
            //Console.WriteLine($"O resultado da divisão de {firstNumber} por {secondNumber} é: {resultEquation}");
        }
    }
}
