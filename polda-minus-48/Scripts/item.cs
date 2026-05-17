using Godot;

public class Item
{
    public string Name;
    public Sprite2D Texture;
    public string Popis;

    public Item(string name,Sprite2D texture,string popis)
    {
        Name= name;
        Texture=texture;
        Popis=popis;
    }
}