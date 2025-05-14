using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder
            .SetHeight(180)
            .SetBodyType("Атлетичний")
            .SetHairColor("Темне")
            .SetEyeColor("Зелені")
            .SetClothes("Броня героя")
            .AddInventoryItem("Меч")
            .AddDeed("Врятував село")
            .Build();
    }

    public Character CreateEnemy(ICharacterBuilder builder)
    {
        return builder
            .SetHeight(190)
            .SetBodyType("Міцний")
            .SetHairColor("Червоне")
            .SetEyeColor("Чорні")
            .SetClothes("Темна мантія")
            .AddInventoryItem("Проклятий посох")
            .AddDeed("Знищив місто")
            .Build();
    }
}

