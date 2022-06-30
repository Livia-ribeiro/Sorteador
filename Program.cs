//using MinhaBiblioteca;
//CursoExemplo1.Executar("Lívia");
#region Variáveis
using PROGRAM;

const int NUMBERS_AMOUNT = 3;
const int PARTICIPANTS_AMOUNT = 5;

Participant[] participants = new Participant[PARTICIPANTS_AMOUNT];
#endregion Variáveis

for(int indexParticipants = 0; indexParticipants < PARTICIPANTS_AMOUNT; indexParticipants++)
{
    participants[indexParticipants] = new Participant();
    Console.WriteLine("Qual o seu nome completo?");
    participants[indexParticipants].Name = Console.ReadLine();
    Console.WriteLine("Qual seu ano de nascimento?");
    int yearBirth = int.Parse(Console.ReadLine());
    participants[indexParticipants].Age = 2022 - yearBirth;
    if (participants[indexParticipants].Age >= 18)
    {
        participants[indexParticipants].Numbers = new int[NUMBERS_AMOUNT];

        Console.WriteLine("Informe três números de 1 a 10");
        for (int indexNumbers = 0; indexNumbers < NUMBERS_AMOUNT; indexNumbers++)
            participants[indexParticipants].Numbers[indexNumbers] = int.Parse(Console.ReadLine());

        participants[indexParticipants].Valid = true;
    }
    else if (participants[indexParticipants].Age < 18)
    {
        Console.WriteLine("Desclassificado");
        participants[indexParticipants].Valid = false;

    }
}


Random sorteador = new Random();
int sorteio = 7;  //sorteador.Next(1, 11);
Console.WriteLine("\nO número sorteado é: " + sorteio);

if (participants[0].Numbers.Contains(sorteio) || participants[1].Numbers.Contains(sorteio) || participants[2].Numbers.Contains(sorteio) ||
    participants[3].Numbers.Contains(sorteio) || participants[4].Numbers.Contains(sorteio))
{
    Console.WriteLine("Alguém ganhou!");
    decimal prizeWinner = 1_000_000;
    int winners = 0;
    foreach(Participant participant in participants)
    {
        if (participant.Numbers != null && participant.Numbers.Contains(sorteio))
            winners++;
    }
    decimal divisionWinners = prizeWinner / winners;
    int evenBonus = 0;
    if (sorteio % 2 == 0 && winners > 1)
        evenBonus = 500;

    //trocar variáveis abaixo por array
    int prizeAge1 = 100 * participants[0].Age + evenBonus;
    int prizeAge2 = 100 * participants[1].Age + evenBonus;
    int prizeAge3 = 100 * participants[2].Age + evenBonus;
    int prizeAge4 = 100 * participants[3].Age + evenBonus;
    int prizeAge5 = 100 * participants[4].Age + evenBonus;

    int superBonus = 0;
    if (sorteio == 7 && winners == 1)
        superBonus = 700_000;

    //Inserir em laço de repetição
    if (participants[0].Numbers != null && participants[0].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[0].Name} de {participants[0].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge1 + superBonus));
    if (participants[1].Numbers != null && participants[1].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[1].Name} de {participants[1].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge2 + superBonus));
    if (participants[2].Numbers != null && participants[2].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[2].Name} de {participants[2].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge3 + superBonus));
    if (participants[3].Numbers != null && participants[3].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[3].Name} de {participants[3].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge4 + superBonus));
    if (participants[4].Numbers != null && participants[4].Numbers.Contains(sorteio))
        Console.WriteLine($"{participants[4].Name} de {participants[4].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAge5 + superBonus));
}
else
{
    Console.WriteLine("ninguém ganhou!");
    decimal consolationPrize = 100_000;
    int validPeoples = 0;

    //Inserir em laço de repetição
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

    //Inserir em laço de repetição
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

