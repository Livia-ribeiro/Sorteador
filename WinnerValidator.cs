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
            bool validator = false;
            foreach (Participant x in participants)
            {
                if (x.Numbers != null && x.Numbers.Contains(raffle)) 
                    validator = true;
            }
            return validator;
        }
    }
}
