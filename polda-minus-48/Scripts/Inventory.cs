using Godot;
using System;
using System.Collections.Generic;

public static class Inventory
{
    public static List<string> Inventar =new List<string>();

    public static bool ItemCheck(string item)
    {
       return Inventar.Contains(item);
    }
    public static void ItemGet(string item)
    {
        Inventar.Add(item);
    }
}
