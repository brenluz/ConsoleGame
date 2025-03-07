﻿namespace Entities.Items;

public class BaseItem: IIdentifiable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
    public Rarities Rarity { get; set; }
    public int Level { get; set; }
    public string Description { get; set; }
    
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    
    public Modifiers Modifier { get; set; }
    
    public BaseItem(int id, string name, int value, Rarities rarity, string description, int hp = 0, int attack = 0, int defense = 0, int speed = 0, Modifiers modifier = Modifiers.Normal)
    {
        Id = id;
        Name = name;
        Value = value;
        Rarity = rarity;
        Level = 1;
        Description = description;
        
        Hp = hp;
        Attack = attack;
        Defense = defense;
        Speed = speed;
        
        Modifier = modifier;
    }
}