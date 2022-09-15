using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM
{
    public class FileHandler
    {
        public void CreateFile()
        {

            string fileName = @"C:\Temp\Winners.txt";
            if (File.Exists(fileName) == false)
                using (FileStream fs = File.Create(fileName));

        }
        //Metodo que recebe um texto e escreve no arquivo.

        public void WriteText(string text)
        {
            using StreamWriter file = new StreamWriter(@"C:\Temp\Winners.txt", append: true);// Dá pra usar só true sem append?
            file.WriteLine(text);

        }
        //Criar metodo que leia todo o contéudo do arquivo e escreva na tela

        public void ReadText()
        {
          
            string[] lines = File.ReadAllLines(@"C:\Temp\Winners.txt");
            Console.WriteLine("Esses foram os últimos vencedores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
