namespace Entities.Enemies
{
    public class BaseEnemy : IIdentifiable
    {
        // <summary> 
        // Atributos do inimigo
        // </summary>
        
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Level { get; set; }
        public int Gold { get; set; }
        
        public Modifiers Modifier { get; set; }
        
        public double Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public BaseEnemy(int id, string name, int level, int gold, double hp, int attack,
            int defense, int speed, Modifiers modifier = Modifiers.Normal)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Level = level;
            Gold = gold;
            Modifier = modifier;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }
    }
}