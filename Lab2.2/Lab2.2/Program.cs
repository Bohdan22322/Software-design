using Interfaces;
using Brands;
using System;

class Program
{
    static void Main()
    {
        TestFactory(new IProneFactory());
        TestFactory(new KiaomiFactory());
        TestFactory(new BalaxyFactory());
    }

    static void TestFactory(ITechFactory factory)
    {
        Console.WriteLine(factory.CreateLaptop().GetInfo());
        Console.WriteLine(factory.CreateNetbook().GetInfo());
        Console.WriteLine(factory.CreateEBook().GetInfo());
        Console.WriteLine(factory.CreateSmartphone().GetInfo());
        Console.WriteLine("------------------------------");
    }
}
