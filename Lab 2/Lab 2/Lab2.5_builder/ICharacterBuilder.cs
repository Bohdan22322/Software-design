public interface ICharacterBuilder
{
    ICharacterBuilder SetHeight(int height);
    ICharacterBuilder SetHairColor(string color);
    ICharacterBuilder SetEyeColor(string color);
    ICharacterBuilder SetOutfit(string outfit);
    ICharacterBuilder AddInventoryItem(string item);
    Character Build();
}
