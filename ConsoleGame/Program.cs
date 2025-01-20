namespace ConsoleGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var battleManager = new BattleSystem.BattleManager();
            battleManager.StartBattle(new Entities.Player("breno"), new Entities.BaseEnemy(1, "Goblin", 1, 10, 10, Entities.Modifiers.Normal, 10, 10, 10, 10)); 
            
        }
    }
}