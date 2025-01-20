namespace Entities
{
    public class BaseEnemy
    {
        // <summary> 
        // Atributos do inimigo
        // </summary>
        
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Gold { get; set; }
        
        public Modifiers Modifier { get; set; }
        
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public BaseEnemy(int id, string name, int level, int exp, int gold, Modifiers modifier, int hp, int attack,
            int defense, int speed)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Level = level;
            Exp = exp;
            Gold = gold;
            Modifier = modifier;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }
    }
}