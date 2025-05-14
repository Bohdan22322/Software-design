using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public string Name => "Освітня підписка";
        public decimal MonthlyFee => 49.99m;
        public int MinSubscriptionPeriod => 1;
        public List<string> Channels => new() { "Наука", "Документальні фільми", "Історія" };
        public List<string> Features => new() { "Доступ до лекцій", "Архів передач" };

        public void PrintInfo()
        {
            Console.WriteLine($"Тип: {Name}");
            Console.WriteLine($"Щомісячна плата: {MonthlyFee} UAH");
            Console.WriteLine($"Мінімальний термін: {MinSubscriptionPeriod} міс.");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
            Console.WriteLine();
        }
    }
}
