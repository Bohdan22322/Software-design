
using Adapter;
using Decorator;
using Bridge;
using Proxy;
using Composite;
using Flyweight;

class Program
{
    static void Main()
    {
    
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Декоратор ===");
        IHero hero = new Mage();
        hero = new Armor(hero);
        hero = new Artifact(hero);
        Console.WriteLine(hero.GetDescription());

        Console.WriteLine("\n=== Адаптер ===");
        ITarget fileLogger = new FileLoggerAdapter();
        fileLogger.Log("Це лог з адаптера (варіант 1)");

        Console.WriteLine("\n=== Міст ===");
        Shape shape = new Circle(new VectorRenderer());
        shape.Draw();

        Console.WriteLine("\n=== Проксі ===");
        var reader = new SmartTextReaderLocker(".*secret.*");
        reader.ReadFile("sample.txt");

        Console.WriteLine("\n=== Компонувальник ===");
        var span = new LightElementNode("span", "inline", false);
        span.AddChild(new LightTextNode("Це елемент <span>"));
        Console.WriteLine(span.OuterHTML());

        Console.WriteLine("\n=== Легковаговик ===");
        var builder = new HtmlBuilder();
        builder.BuildFromText(new[] { "Заголовок", "    Цитата", "Текстовий блок..." });
        builder.Display();
    }
}
