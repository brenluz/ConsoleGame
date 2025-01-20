using System.Linq.Expressions;
using BattleSystem.Exceptions;
using Entities.Enemies;
using Entities;

namespace BattleSystem;

public class BattleManager
{
   public void StartBattle(Player player, BaseEnemy enemy)  
   {
      Console.WriteLine("Battle Started!");
      Console.WriteLine($"Player {player.Name} is fighting a {enemy.Modifier} level {enemy.Level} {enemy.Name}");
      
      if(player.Speed > enemy.Speed)
      {
         PlayerTurn(player, enemy);
         EnemyTurn(player, enemy);
      }
      else
      {
         EnemyTurn(player, enemy);
         PlayerTurn(player, enemy);
      }
   }

   private static void PlayerTurn(Player player, BaseEnemy enemy)
   {
      var random = new Random();
      Console.WriteLine("Player's turn");
      Console.WriteLine("Player attacks the enemy");
      var attack = player.Attack * random.Next(9, 11)*0.1;
      if (attack > enemy.Defense) 
      {
         enemy.Hp -= attack - enemy.Defense;
      }   
   }
   
   private static void EnemyTurn(Player player, BaseEnemy enemy)
   {
      var random = new Random();
      Console.WriteLine("Enemy's turn");
      Console.WriteLine("Enemy attacks the player");
      var attack = enemy.Attack * random.Next(9, 11)*0.1;   
      if (attack > player.Defense) 
      {
         player.Hp -= enemy.Attack - player.Defense;
      }   
   }
}