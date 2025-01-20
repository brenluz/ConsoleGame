using Entities;
using Entities.Items;

namespace Repositories;

public class ItemRepository: BaseRepository<BaseItem>
{
    protected override IList<BaseItem> Items { get; } = new List<BaseItem>
    {
        new BaseItem(1, "Sword", 10, Rarities.Common,  "A basic sword"),
        new BaseItem(2, "Shield", 10, Rarities.Common,  "A basic shield"),
        new BaseItem(3, "Potion", 10, Rarities.Common, "A basic potion", 10),
        new BaseItem(4, "Boots", 10, Rarities.Common, "A basic boots", 0, 0, 0, 10),
    };

}