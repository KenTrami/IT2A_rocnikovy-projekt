using Godot;
using System;
using System.Collections.Generic;
public partial class InventoryUI : Panel
{
    private List<TextureButton> slots = new();

    public override void _Ready()
    {
        foreach (Node child in GetChildren())
        {
            if (child is TextureButton button)
            {
                slots.Add(button);
            }
        }
    }

    public void RefreshInventory()
    {
        // vymaže sloty
        foreach (TextureButton slot in slots)
        {
            slot.TextureNormal = null;
        }

        // nastaví itemy
        for (int i = 0; i < Inventory.Inventar.Count; i++)
        {
            slots[i].TextureNormal =
                Inventory.Inventar[i].Texture;
        }
    }
}
