using Entities.Items;

namespace Entities;

public class Player
{
    // Player properties
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
        
    public double Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    public int Gold { get; set; }


    // Player inventory and equipped items
    // the player can have up to 5 equipped items and only those can affect the player's stats
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
    
    // Methods to equip and unequip items From/To the players's inventory, updating the players stats in the process
    public void EquipItem(BaseItem item)
    {
        // TODO: Implement EquippedItemsException
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
        Console.WriteLine($"You got {item.Hp} HP, {item.Attack} Attack, {item.Defense} Defense and {item.Speed} Speed");
    }
    
    public void UnequipItem(BaseItem item)
    {
        // TODO: Implement EquippedItemsException
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
    
    public void OpenInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"{item.Name} - {item.Description}");
        }
    }
    
    public void OpenEquippedItems()
    {
        Console.WriteLine("Equipped Items:");
        foreach (var item in EquippedItems)
        {
            Console.WriteLine($"{item.Name} - {item.Description}");
        }
    }
    
    
}