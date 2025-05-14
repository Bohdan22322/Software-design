using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public string Name => "Домашня підписка";
        public decimal MonthlyFee => 99.99m;
        public int MinSubscriptionPeriod => 3;
        public List<string> Channels => new() { "Новини", "Розваги", "Фільми" };
        public List<string> Features => new() { "HD Якість", "Батьківський контроль" };

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

