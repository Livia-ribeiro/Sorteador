//using MinhaBiblioteca;
//CursoExemplo1.Executar("Lívia");
#region Variáveis
const int NUMBERS_AMOUNT = 3;
int[] numbersPerson1 = new int[NUMBERS_AMOUNT];
int[] numbersPerson2 = new int[NUMBERS_AMOUNT];
int[] numbersPerson3 = new int[NUMBERS_AMOUNT];
int[] numbersPerson4 = new int[NUMBERS_AMOUNT];
int[] numbersPerson5 = new int[NUMBERS_AMOUNT];

bool[] validPersons = new bool[4];
#endregion Variáveis

#region First Person
Console.WriteLine("Qual o seu nome completo?");
string firstPerson = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int birthDate1 = int.Parse(Console.ReadLine());
int ageFirstPerson = 2022 - birthDate1;
if (ageFirstPerson >= 18)
{
    Console.WriteLine("Informe três números de 1 a 10");
    for(int index = 0; index < NUMBERS_AMOUNT; index++)
        numbersPerson1[index] = int.Parse(Console.ReadLine());

    validPersons[0] = true;
}
else if (ageFirstPerson < 18)
{
    Console.WriteLine("Desclassificado");
    validPersons[0] = false;

}
#endregion First Person

#region Second Person
Console.WriteLine("\nQual o seu nome completo?");
string secondPerson = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int birthDate2 = int.Parse(Console.ReadLine());
int ageSecondPerson = 2022 - birthDate2;
if (ageSecondPerson >= 18)
{
    Console.WriteLine("Informe três números de 1 a 10");
    for(int index = 0; index < NUMBERS_AMOUNT; index++)
        numbersPerson2[index] = int.Parse(Console.ReadLine());
  
    validPersons[1] = true;
}
else if (ageSecondPerson < 18)
{
    Console.WriteLine("Desclassificado!");
    validPersons[1] = false;
}
#endregion Second Person

#region Third Person
Console.WriteLine("\nQual o seu nome completo?");
string thirdPerson = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int birthDate3 = int.Parse(Console.ReadLine());
int ageThirdPerson = 2022 - birthDate3;
if (ageThirdPerson >= 18)
{
    Console.WriteLine("Informe três números de 1 a 10");
    for(int index = 0; index < NUMBERS_AMOUNT; index++)
        numbersPerson3[index] = int.Parse(Console.ReadLine());
    
    validPersons[2] = true;
}
else if (ageThirdPerson < 18)
{
    Console.WriteLine("Desclassificado!");
    validPersons[2] = false;
}
#endregion Third Person

#region Fourth Person
Console.WriteLine("\nQual o seu nome completo?");
string fourthPerson = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int birthDate4 = int.Parse(Console.ReadLine());
int ageFourthPerson = 2022 - birthDate4;
if (ageFourthPerson >= 18)
{
    Console.WriteLine("Informe três números de 1 a 10");
    for(int index = 0; index < NUMBERS_AMOUNT; index++)
        numbersPerson4[index] = int.Parse(Console.ReadLine());
    
    validPersons[3] = true;
}
else if (ageFourthPerson < 18)
{
    Console.WriteLine("Desclassificado!");
    validPersons[3] = false;
}
#endregion Fourth Person

#region Fifth Person
Console.WriteLine("\nQual o seu nome completo?");
string fifthPerson = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int birthDate5 = int.Parse(Console.ReadLine());
int ageFifthPerson = 2022 - birthDate5;
if (ageFifthPerson >= 18)
{
    Console.WriteLine("Informe três números de 1 a 10");
    for(int index = 0; index < NUMBERS_AMOUNT; index++)
        numbersPerson5[index] = int.Parse(Console.ReadLine());
    
    validPersons[4] = true;
}
else if (ageFifthPerson < 18)
{
    Console.WriteLine("Desclassificado!");
    validPersons[4] = false;

}
#endregion Fifth Person

Random sorteador = new Random();
int sorteio = 7;  //sorteador.Next(1, 11);
Console.WriteLine("\nO número sorteado é: " + sorteio);

if (numbersPerson1.Contains(sorteio) || numbersPerson2.Contains(sorteio) || numbersPerson3.Contains(sorteio) ||
    numbersPerson4.Contains(sorteio) || numbersPerson5.Contains(sorteio))
{
    Console.WriteLine("Alguém ganhou!");
    decimal prizeWinner = 1_000_000;
    int winners = 0;
    if (numbersPerson1.Contains(sorteio))
        winners++;
    if (numbersPerson2.Contains(sorteio))
        winners++;
    if (numbersPerson3.Contains(sorteio))
        winners++;
    if (numbersPerson4.Contains(sorteio))
        winners++;
    if (numbersPerson5.Contains(sorteio))
        winners++;
    decimal divisionWinners = prizeWinner / winners;
    int evenBonus = 0;
    if (sorteio % 2 == 0 && winners > 1)
        evenBonus = 500;
    int prizeAge1 = 100 * ageFirstPerson + evenBonus;
    int prizeAge2 = 100 * ageSecondPerson + evenBonus;
    int prizeAge3 = 100 * ageThirdPerson + evenBonus;
    int prizeAge4 = 100 * ageFourthPerson + evenBonus;
    int prizeAge5 = 100 * ageFifthPerson + evenBonus;

    int superBonus = 0;
    if (sorteio == 7 && winners == 1)
        superBonus = 700_000;

    if (numbersPerson1.Contains(sorteio))
        Console.WriteLine($"{firstPerson} de {ageFirstPerson} anos ganhou um prêmio de " + (divisionWinners + prizeAge1 + superBonus));
    if (numbersPerson2.Contains(sorteio))
        Console.WriteLine($"{secondPerson} de {ageSecondPerson} anos ganhou um prêmio de " + (divisionWinners + prizeAge2 + superBonus));
    if (numbersPerson3.Contains(sorteio))
        Console.WriteLine($"{thirdPerson} de {ageThirdPerson} anos ganhou um prêmio de " + (divisionWinners + prizeAge3 + superBonus));
    if (numbersPerson4.Contains(sorteio))
        Console.WriteLine($"{fourthPerson} de {ageFourthPerson} anos ganhou um prêmio de " + (divisionWinners + prizeAge4 + superBonus));
    if (numbersPerson5.Contains(sorteio))
        Console.WriteLine($"{fifthPerson} de {ageFifthPerson} anos ganhou um prêmio de " + (divisionWinners + prizeAge5 + superBonus));
}
else
{
    Console.WriteLine("ninguém ganhou!");
    decimal consolationPrize = 100_000;
    int validPeoples = 0;
    if (validPersons[0])
        validPeoples++;
    if (validPersons[1])
        validPeoples++;
    if (validPersons[2])
        validPeoples++;
    if (validPersons[3])
        validPeoples++;
    if (validPersons[4])
        validPeoples++;
    decimal divisionPrize = consolationPrize / validPeoples;
    if (validPersons[0])
        Console.WriteLine($"{firstPerson} de {ageFirstPerson} anos ganhou um prêmio de consolação no valor de {divisionPrize}");
    if (validPersons[1])
        Console.WriteLine($"{secondPerson} de {ageSecondPerson} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");
    if (validPersons[2])
        Console.WriteLine($"{thirdPerson} de {ageThirdPerson} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");
    if (validPersons[3])
        Console.WriteLine($"{fourthPerson} de {ageFourthPerson} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");
    if (validPersons[4])
        Console.WriteLine($"{fifthPerson} de {ageFifthPerson} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");





}

