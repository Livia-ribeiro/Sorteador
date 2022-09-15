using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM
{
    public class HistoricoVencedores
    {
        public void CreateFile()
        {

            string fileName = @"C:\Temp\HistoricoVencedores.csv";
                using (FileStream fs = File.Create(fileName));

        }

        public void WriteText(string nome, int age, decimal prize)
        {
            using StreamWriter file = new StreamWriter(@"C:\Temp\HistoricoVencedores.csv", append: true);
            file.WriteLine($"{nome} ; {age} ; {prize}");

        }
    }
}
