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
            // Verificar se arquivo já existe. (para não excluir o que já existe)
            string fileName = @"C:\Temp\Winners.txt";
            using (FileStream fs = File.Create(fileName));
            
           
        }
        // Criar metodo que recebe um texto e escreve no arquivo.
    }
}
