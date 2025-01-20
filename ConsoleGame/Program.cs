using Entities;
using Repositories;

namespace ConsoleGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var enemyRepository = new EnemyRepository();
            var itemRepository = new ItemRepository();
            
            var player = new Player(1, "Player");
            var enemy = enemyRepository.Get(1);
            
            var battleManager = new BattleSystem.BattleManager();
            battleManager.StartBattle(player, enemy);   
            
        }
    }
}