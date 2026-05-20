using Godot;
using System;

public partial class Slot1 : TextureButton
{
    public Sprite2D itemSprite;

    public void SetItem(Sprite2D sprite)
    {
        // odstraníme starý sprite
        foreach (var child in GetChildren())
            child.QueueFree();

        // instanciujeme nový Sprite2D
        itemSprite = sprite.Duplicate() as Sprite2D;
        AddChild(itemSprite);

        // volitelně uprav pozici a scale
        itemSprite.Position = Vector2.Zero;
        itemSprite.Scale = new Vector2(0.5f, 0.5f);
    }
}