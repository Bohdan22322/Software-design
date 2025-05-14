public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder.SetHeight(180)
                      .SetHairColor("Blonde")
                      .SetEyeColor("Blue")
                      .SetOutfit("Armor")
                      .AddInventoryItem("Sword")
                      .AddInventoryItem("Shield")
                      .Build();
    }
}
