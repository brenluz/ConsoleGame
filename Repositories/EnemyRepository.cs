using Entities;

namespace Repositories;

public class EnemyRepository : BaseRepository<BaseEnemy>
{
    protected override IList<BaseEnemy>  Items { get; } = new List<BaseEnemy>
    {
        new BaseEnemy(1, "Goblin", 1, 10, 10, 10, 10, 10),
    };

}