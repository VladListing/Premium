using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerBonus
{
    enum Position : int
    {
        Junior = 100,
        Middle = 120,
        Senior = 150,
        Teamleader = 180
    }


    class Accauntant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            if ((int)worker < hours )
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
