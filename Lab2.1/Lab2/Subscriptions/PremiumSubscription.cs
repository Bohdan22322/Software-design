using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public string Name => "Преміум підписка";
        public decimal MonthlyFee => 199.99m;
        public int MinSubscriptionPeriod => 6;
        public List<string> Channels => new() { "Спорт", "Фільми", "Серіали", "Новинки кіно" };
        public List<string> Features => new() { "4K Якість", "Без реклами", "Доступ офлайн" };

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

