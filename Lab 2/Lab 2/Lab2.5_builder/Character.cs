public class Character
{
    public int Height { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Outfit { get; set; }
    public List<string> Inventory { get; set; } = new();

    public override string ToString() =>
        $"Height: {Height}, Hair: {HairColor}, Eyes: {EyeColor}, Outfit: {Outfit}, Items: {string.Join(", ", Inventory)}";
}
