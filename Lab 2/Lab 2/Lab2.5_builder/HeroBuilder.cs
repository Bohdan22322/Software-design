public class HeroBuilder : ICharacterBuilder
{
    private Character character = new();

    public ICharacterBuilder SetHeight(int height) { character.Height = height; return this; }
    public ICharacterBuilder SetHairColor(string color) { character.HairColor = color; return this; }
    public ICharacterBuilder SetEyeColor(string color) { character.EyeColor = color; return this; }
    public ICharacterBuilder SetOutfit(string outfit) { character.Outfit = outfit; return this; }
    public ICharacterBuilder AddInventoryItem(string item) { character.Inventory.Add(item); return this; }

    public Character Build() => character;
}
