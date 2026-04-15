using Godot;
using System;

public partial class Main : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var sprite = GetNode<Sprite2D>("Sprite2D");
        var camera = GetNode<Camera2D>("Camera2D");

        Vector2 textureSize = sprite.Texture.GetSize();
        Vector2 screenSize = GetViewportRect().Size;

        float zoomX = textureSize.X / screenSize.X;
        float zoomY = textureSize.Y / screenSize.Y;

        camera.Zoom = new Vector2(zoomX, zoomY);
        camera.Position = textureSize / 2;

		camera.MakeCurrent();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_buttonhrat_pressed()
	{
		GetTree().ChangeSceneToFile("ress://room_1.tscn");
	}
}
