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
    
    public virtual IList<BaseItem> Inventory { get; set; }
    public virtual IList<BaseItem> EquippedItems { get; set; }
}