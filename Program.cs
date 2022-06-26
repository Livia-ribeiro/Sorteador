//using MinhaBiblioteca;
//CursoExemplo1.Executar("Lívia");
#region Variáveis
using PROGRAM;

const int NUMBERS_AMOUNT = 3;

Participant[] participants = new Participant[5];
#endregion Variáveis

#region First Person
participants[0] = new Participant();
Console.WriteLine("Qual o seu nome completo?");
participants[0].Name = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int yearBirth1 = int.Parse(Console.ReadLine());
participants[0].Age = 2022 - yearBirth1;
if (participants[0].Age >= 18)
{
    participants[0].Numbers = new int[NUMBERS_AMOUNT];

    Console.WriteLine("Informe três números de 1 a 10");
    for(int indexNumbers = 0; indexNumbers < NUMBERS_AMOUNT; indexNumbers++)
        participants[0].Numbers[indexNumbers] = int.Parse(Console.ReadLine());

    participants[0].Valid = true;
}
else if (participants[0].Age < 18)
{
    Console.WriteLine("Desclassificado");
    participants[0].Valid = false;

}
#endregion First Person

#region Second Person
participants[1] = new Participant();
Console.WriteLine("\nQual o seu nome completo?");
participants[1].Name = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int yearBirth2 = int.Parse(Console.ReadLine());
participants[1].Age = 2022 - yearBirth2;
if (participants[1].Age >= 18)
{
    participants[1].Numbers = new int[NUMBERS_AMOUNT];

    Console.WriteLine("Informe três números de 1 a 10");
    for(int indexNumbers = 0; indexNumbers < NUMBERS_AMOUNT; indexNumbers++)
        participants[1].Numbers[indexNumbers] = int.Parse(Console.ReadLine());
  
    participants[1].Valid = true;
}
else if (participants[1].Age < 18)
{
    Console.WriteLine("Desclassificado!");
    participants[1].Valid = false;
}
#endregion Second Person

#region Third Person
participants[2] = new Participant();
Console.WriteLine("\nQual o seu nome completo?");
participants[2].Name = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int yearBirth3 = int.Parse(Console.ReadLine());
participants[2].Age = 2022 - yearBirth3;
if (participants[2].Age >= 18)
{
    participants[2].Numbers = new int[NUMBERS_AMOUNT];

    Console.WriteLine("Informe três números de 1 a 10");
    for(int indexNumbers = 0; indexNumbers < NUMBERS_AMOUNT; indexNumbers++)
        participants[2].Numbers[indexNumbers] = int.Parse(Console.ReadLine());
    
    participants[2].Valid = true;
}
else if (participants[2].Age < 18)
{
    Console.WriteLine("Desclassificado!");
    participants[2].Valid = false;
}
#endregion Third Person

#region Fourth Person
participants[3] = new Participant();
Console.WriteLine("\nQual o seu nome completo?");
participants[3].Name = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int yearBirth4 = int.Parse(Console.ReadLine());
participants[3].Age = 2022 - yearBirth4;
if (participants[3].Age >= 18)
{
    participants[3].Numbers = new int[NUMBERS_AMOUNT];

    Console.WriteLine("Informe três números de 1 a 10");
    for(int indexNumbers = 0; indexNumbers < NUMBERS_AMOUNT; indexNumbers++)
        participants[3].Numbers[indexNumbers] = int.Parse(Console.ReadLine());
    
    participants[3].Valid = true;
}
else if (participants[3].Age < 18)
{
    Console.WriteLine("Desclassificado!");
    participants[3].Valid = false;
}
#endregion Fourth Person

#region Fifth Person
participants[4] = new Participant();
Console.WriteLine("\nQual o seu nome completo?");
participants[4].Name = Console.ReadLine();
Console.WriteLine("Qual seu ano de nascimento?");
int yearBirth5 = int.Parse(Console.ReadLine());
participants[4].Age = 2022 - yearBirth5;
if (participants[4].Age >= 18)
{
    participants[4].Numbers = new int[NUMBERS_AMOUNT];

    Console.WriteLine("Informe três números de 1 a 10");
    for(int indexNumbers = 0; indexNumbers < NUMBERS_AMOUNT; indexNumbers++)
        participants[4].Numbers[indexNumbers] = int.Parse(Console.ReadLine());
    
    participants[4].Valid = true;
}
else if (participants[4].Age < 18)
{
    Console.WriteLine("Desclassificado!");
    participants[4].Valid = false;

}
#endregion Fifth Person

Random sorteador = new Random();
int sorteio = 7;  //sorteador.Next(1, 11);
Console.WriteLine("\nO número sorteado é: " + sorteio);

if (participants[0].Numbers.Contains(sorteio) || participants[1].Numbers.Contains(sorteio) || participants[2].Numbers.Contains(sorteio) ||
    participants[3].Numbers.Contains(sorteio) || participants[4].Numbers.Contains(sorteio))
{
    Console.WriteLine("Alguém ganhou!");
    decimal prizeWinner = 1_000_000;
    int winners = 0;
    if (participants[0].Numbers.Contains(sorteio))
        winners++;
    if (participants[1].Numbers.Contains(sorteio))
        winners++;
    if (participants[2].Numbers.Contains(sorteio))
        winners++;
    if (participants[3].Numbers.Contains(sorteio))
        winners++;
    if (participants[4].Numbers.Contains(sorteio))
        winners++;
    decimal divisionWinners = prizeWinner / winners;
    int evenBonus = 0;
    if (sorteio % 2 == 0 && winners > 1)
        evenBonus = 500;
    int prizeAge1 = 100 * participants[0].Age + evenBonus;
    int prizeAge2 = 100 * participants[1].Age + evenBonus;
    int prizeAge3 = 100 * participants[2].Age + evenBonus;
    int prizeAge4 = 100 * participants[3].Age + evenBonus;
    int prizeAge5 = 100 * participants[4].Age + evenBonus;

    int superBonus = 0;
    if (sorteio == 7 && winners == 1)
        superBonus = 700_000;

    if (participants[0].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[0].Name} de {participants[0].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge1 + superBonus));
    if (participants[1].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[1].Name} de {participants[1].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge2 + superBonus));
    if (participants[2].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[2].Name} de {participants[2].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge3 + superBonus));
    if (participants[3].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[3].Name} de {participants[3].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge4 + superBonus));
    if (participants[4].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[4].Name} de {participants[4].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge5 + superBonus));
}
else
{
    Console.WriteLine("ninguém ganhou!");
    decimal consolationPrize = 100_000;
    int validPeoples = 0;
    if (participants[0].Valid)
        validPeoples++;
    if (participants[1].Valid)
        validPeoples++;
    if (participants[2].Valid)
        validPeoples++;
    if (participants[3].Valid)
        validPeoples++;
    if (participants[4].Valid)
        validPeoples++;
    decimal divisionPrize = consolationPrize / validPeoples;
    if (participants[0].Valid)
        Console.WriteLine($"{participants[0].Name} de {participants[0].Age} anos ganhou um prêmio de consolação no valor de {divisionPrize}");
    if (participants[1].Valid)
        Console.WriteLine($"{participants[1].Name} de {participants[1].Age} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");
    if (participants[2].Valid)
        Console.WriteLine($"{participants[2].Name} de {participants[2].Age} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");
    if (participants[3].Valid)
        Console.WriteLine($"{participants[3].Name} de {participants[3].Age} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");
    if (participants[4].Valid)
        Console.WriteLine($"{participants[4].Name} de {participants[4].Age} anos ganhou um prêmio de consoloação no valor de {divisionPrize}");





}

