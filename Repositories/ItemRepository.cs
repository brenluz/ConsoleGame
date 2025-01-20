using Entities;

namespace Repositories;

public class ItemRepository: BaseRepository<BaseItem>
{
    protected override IList<BaseItem> Items { get; } = new List<BaseItem>
    {
        new BaseItem(1, "Sword", 10, Rarities.Common, 10, "A basic sword"),

    };

}