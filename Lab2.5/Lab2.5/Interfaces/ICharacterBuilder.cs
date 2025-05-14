using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICharacterBuilder
{
    ICharacterBuilder SetHeight(double height);
    ICharacterBuilder SetBodyType(string bodyType);
    ICharacterBuilder SetHairColor(string hairColor);
    ICharacterBuilder SetEyeColor(string eyeColor);
    ICharacterBuilder SetClothes(string clothes);
    ICharacterBuilder AddInventoryItem(string item);
    ICharacterBuilder AddDeed(string deed);
    Character Build();
}

