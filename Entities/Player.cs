using Entities.Items;

namespace Entities;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
        
    public int Hp { get; set; }
    private int Attack { get; set; }
    private int Defense { get; set; }
    private int Speed { get; set; }
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
        EquippedItems = new List<BaseItem>(5);
    }   
    
    public void EquipItem(BaseItem item)
    {
        if (EquippedItems.Count >= 5)
        {
            Console.WriteLine("You can't equip more than 5 items");
            return;
        }
        EquippedItems.Add(item);
        Hp += item.Hp;
        Attack += item.Attack;
        Defense += item.Defense;
        Speed += item.Speed;
        Console.WriteLine($"You successfully equipped the {item.Name}");
    }
    
    public void UnequipItem(BaseItem item)
    {
        if(!EquippedItems.Contains(item))
        {
            Console.WriteLine("You don't have this item equipped");
            return;
        }
        EquippedItems.Remove(item);
        Hp -= item.Hp;
        Attack -= item.Attack;
        Defense -= item.Defense;
        Speed -= item.Speed;
        Console.WriteLine($"You successfully unequipped the {item.Name}");
    }
    
    public void AddItemToInventory(BaseItem item)
    {
        Inventory.Add(item);
        Console.WriteLine($"The {item.Name} was added to your inventory");
    }
}