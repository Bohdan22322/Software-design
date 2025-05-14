using System;
using System.Collections.Generic;
using Interfaces;
using Classes;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        {
            // Создание товара
            IProduct milk = new Product("Молоко", "л", new Money(35, 50, "UAH"), "Молочні продукти");
            IProduct bread = new Product("Хліб", "шт", new Money(18, 75, "UAH"), "Випічка");

            // Создание склада и добавление товаров
            var warehouse = new Warehouse();
            warehouse.Incoming(milk, 100, DateTime.Now);
            warehouse.Incoming(bread, 200, DateTime.Now);

            // Печать приходной накладной
            Reporting.PrintIncomingInvoice(milk, 100, DateTime.Now);
            Reporting.PrintIncomingInvoice(bread, 200, DateTime.Now);

            // Продажа товара (расход)
            warehouse.Outgoing("Молоко", 30, DateTime.Now);
            warehouse.Outgoing("Хліб", 50, DateTime.Now);

            // Печать расходной накладной
            Reporting.PrintOutgoingInvoice(milk, 30, DateTime.Now);
            Reporting.PrintOutgoingInvoice(bread, 50, DateTime.Now);

            // Инвентаризация
            var inventory = warehouse.GetInventory();
            Reporting.PrintInventory(inventory);
        }
    }
}