public class Virus
{
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public List<Virus> Children { get; set; } = new();

    public Virus Clone()
    {
        Virus clone = (Virus)this.MemberwiseClone();
        clone.Children = Children.Select(child => child.Clone()).ToList();
        return clone;
    }
}
