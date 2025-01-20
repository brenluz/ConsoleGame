namespace Entities;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
        
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    public int Gold { get; set; }


    public IList<BaseItem> Inventory { get; set; }
    public IList<BaseItem> EquippedItems { get; set; }
    
    public Player(int id, string name)
    {
        Id = id;
        Name = name;
        Level = 1;
        Hp = 100;
        Attack = 10;
        Defense = 10;
        Speed = 10;
        Gold = 0;
        
        Inventory = new List<BaseItem>();
        EquippedItems = new List<BaseItem>();
        
    }   
}