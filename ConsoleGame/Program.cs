using Entities;
using Repositories;
using BattleSystem.Exceptions;
namespace ConsoleGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Created the object repositories where enemy and item information is stored
            var enemyRepository = new EnemyRepository();
            var itemRepository = new ItemRepository();
            
            // Creates the player and also looks for an enemy whithin the enemy repository
            var player = new Player(1, "Player");
            var enemy = enemyRepository.Get(1);
            
            // Creates the battle manager that controls everything about the battle, and starts a battle
            var battleManager = new BattleSystem.BattleManager();
            try
            {
                battleManager.StartBattle(player, enemy);   
            }
            catch (BattleInputException e)
            {
                Console.WriteLine("Battle input Invald");
            }
            
        }
    }
}