using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerBonus
{
    enum Position : int
    {
        Junior,
        Middle,
        Senior,
        Teamleader
    }


    class Accauntant
    {
        public int GetHours(Position programmer)
        {
            var a =0;
            switch (programmer)
            {
                case Position.Junior:
                    a = 100;
                    break;

                case Position.Middle:
                    a = 120;
                    break;

                case Position.Senior:
                    a = 150;
                    break;

                case Position.Teamleader:
                    a = 180;
                    break;

                default:
                    throw new InvalidOperationException("unknown item type");
            }

            return a;
        }



        public bool AskForBonus(Position worker, int hours)
        {
            if (GetHours(worker) < hours )
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
