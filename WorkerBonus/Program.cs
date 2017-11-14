using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите пороговое количество отработанных часов:");
            int hoursStep = Convert.ToInt32(Console.ReadLine());

            Accauntant accauntant = new Accauntant();

            if ( accauntant.AskForBonus(Position.Senior, hoursStep) == false)
            {
                Console.WriteLine("переработки нет , премия не начисляется ");
            }
            else
            {
                Console.WriteLine(" есть переработка , начисляется премия");
            }

            Console.ReadKey();
        }
    }
}
