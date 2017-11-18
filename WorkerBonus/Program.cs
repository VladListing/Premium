using System;

namespace WorkerBonus
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("введите пороговое количество отработанных часов:");
            var hoursStep = Convert.ToInt32(Console.ReadLine());

            var accauntant = new Accauntant();

            Console.WriteLine(accauntant.AskForBonus(Position.Senior, hoursStep) == false
                ? "переработки нет , премия не начисляется "
                : " есть переработка , начисляется премия");

            Console.ReadKey();
        }
    }
}
