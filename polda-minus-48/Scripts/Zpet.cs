using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Zpet : TextureButton
{
	private Label label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var Sipka=GetNode<TextureButton>("/root/Chodba/Controls/Panel/TextureButton");
		label = GetNode<Label>("/root/Chodba/Controls/CanvasLayer/Panel/Label");

		Pressed+=_on_texture_button_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_texture_button_pressed()
	{
		GetNode<Panel>("/root/Chodba/Controls/Panel").Hide();
		label.Text="";
	}

}
