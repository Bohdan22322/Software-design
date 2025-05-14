using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var director = new CharacterDirector();

        var heroBuilder = new HeroBuilder();
        var enemyBuilder = new EnemyBuilder();

        var hero = director.CreateHero(heroBuilder);
        var enemy = director.CreateEnemy(enemyBuilder);

        Console.WriteLine("=== Герой ===");
        hero.ShowInfo();

        Console.WriteLine("\n=== Ворог ===");
        enemy.ShowInfo();
    }
}
