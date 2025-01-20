namespace Entities
{
    public class BaseEnemy
    {
        // <summary> 
        // The unique identifier for the enemy
        // </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Gold { get; set; }
        
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        

    }
}