using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public double Height { get; set; }
    public string BodyType { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothes { get; set; }
    public List<string> Inventory { get; set; } = new();
    public List<string> Deeds { get; set; } = new();

    public void ShowInfo()
    {
        Console.WriteLine($"Зріст: {Height}, Статура: {BodyType}, Волосся: {HairColor}, Очі: {EyeColor}, Одяг: {Clothes}");
        Console.WriteLine("Інвентар: " + string.Join(", ", Inventory));
        Console.WriteLine("Вчинки: " + string.Join(", ", Deeds));
    }
}

