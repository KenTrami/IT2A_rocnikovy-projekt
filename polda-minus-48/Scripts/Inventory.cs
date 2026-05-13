using Godot;
using System;
using System.Collections.Generic;

public static class Inventory
{
    public static List<Sprite2D> Inventar =new List<Sprite2D>() ;

    public static bool ItemCheck(Sprite2D item)
    {
       return Inventar.Contains(item);
    }
    public static void ItemGet(Sprite2D item)
    {
        Inventar.Add(item);
    }
}
