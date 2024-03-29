﻿//using MinhaBiblioteca;
//CursoExemplo1.Executar("Lívia");
#region Variáveis
using PROGRAM;

const int NUMBERS_AMOUNT = 3;
const int PARTICIPANTS_AMOUNT = 5;

Participant[] participants = new Participant[PARTICIPANTS_AMOUNT];
int[] prizeAges = new int[PARTICIPANTS_AMOUNT];
#endregion Variáveis

HistoricoVencedores informaçõesVencedores = new HistoricoVencedores();
informaçõesVencedores.CreateFile();

FileHandler manipuladorAquivos = new FileHandler();
manipuladorAquivos.CreateFile();

manipuladorAquivos.ReadText();


for (int indexParticipants = 0; indexParticipants < PARTICIPANTS_AMOUNT; indexParticipants++)
{
    participants[indexParticipants] = new Participant();
    Console.WriteLine("\nQual o seu nome completo?");
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

WinnerValidator meuValidador  = new WinnerValidator();
if (meuValidador.HasWinner(participants, sorteio))
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

    for (int index = 0; index < PARTICIPANTS_AMOUNT; index++)
        prizeAges[index] = 100 * participants[index].Age + evenBonus;
  

    int superBonus = 0;
    if (sorteio == 7 && winners == 1)
        superBonus = 700_000;


    for (int indexParticipants = 0; indexParticipants < PARTICIPANTS_AMOUNT; indexParticipants++)
    {
        if (participants[indexParticipants].Numbers != null && participants[indexParticipants].Numbers.Contains(sorteio))
        {
            Console.WriteLine($"{participants[indexParticipants].Name} de {participants[indexParticipants].Age} anos ganhou um prêmio de " + (divisionWinners + prizeAges[indexParticipants] + superBonus));
            manipuladorAquivos.WriteText(participants[indexParticipants].Name);
            informaçõesVencedores.WriteText(participants[indexParticipants].Name, participants[indexParticipants].Age, (divisionWinners + prizeAges[indexParticipants] + superBonus));
        }
    }

  

}
else
{
    Console.WriteLine("ninguém ganhou!");
    decimal consolationPrize = 100_000;
    int validPeoples = 0;

   
   for (int index = 0 ; index < PARTICIPANTS_AMOUNT ; index++)
    {
        if (participants[index].Valid)
            validPeoples++;
    }

    decimal divisionPrize = consolationPrize / validPeoples;

    for ( int indexParticipants = 0; indexParticipants < PARTICIPANTS_AMOUNT ; indexParticipants++)
    {
         if (participants[indexParticipants].Valid)
            Console.WriteLine($"{participants[indexParticipants].Name} de {participants[indexParticipants].Age} anos ganhou um prêmio de consolação no valor de {divisionPrize}");
    }
  
}

// atividade1: anunciar os vencedores anteriores.
// atividade2: criar uma nova classe que salve o nome, idade e valor ganho dos participantes em um arquivo CSV.
