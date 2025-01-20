using Entities;

namespace BattleSystem;

public class BattleManager
{
   public void StartBattle(Player player, BaseEnemy enemy)  
   {
      Console.WriteLine("Battle Started!");
      Console.WriteLine($"You are fighting a {enemy.Name}");
      Console.ReadLine();
   } 
   
}