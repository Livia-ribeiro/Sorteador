using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAM
{
    public class WinnerValidator
    {
        public bool HasWinner(Participant[] participants, int raffle)
        {
            bool temVencedor = false;
            foreach (Participant participante in participants)
            {
                if (participante.Numbers != null && participante.Numbers.Contains(raffle))
                    temVencedor = true;
            }
            return temVencedor;
        }
    }
}
