using Entities;

namespace BattleSystem;

public class BattleManager
{
   public void StartBattle(Player player, BaseEnemy enemy)  
   {
      Console.WriteLine("Battle Started!");
      Console.WriteLine($"Player {player.Name} is fighting a {enemy.Modifier} level {enemy.Level} {enemy.Name}");
      Console.ReadLine();
   } 
   
}