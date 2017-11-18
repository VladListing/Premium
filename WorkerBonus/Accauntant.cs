using System;

namespace WorkerBonus
{
    public enum Position 
    {
        Junior,
        Middle,
        Senior,
        Teamleader
    }

    public class Accauntant
    {
        public int GetHours(Position programmer)
        {
            switch (programmer)
            {
                case Position.Junior:
                    return 100;
                case Position.Middle:
                    return 120;
                case Position.Senior:
                    return 150;
                case Position.Teamleader:
                    return 180;
                default:
                    throw new ArgumentException("unknown programmer position");
            }
        }

        public bool AskForBonus(Position worker, int hours)
        {
            return GetHours(worker) >= hours;
        }
    }
}
