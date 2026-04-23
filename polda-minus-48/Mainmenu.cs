using Godot;
using System;

public partial class Mainmenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_hrat_pressed()
	    {
		    GetTree().ChangeSceneToFile("res://Scenes/Room1.tscn");
			GD.Print("Funguju");
			
	    }
	private void _on_button_3_pressed()
	{
		GetTree().Quit();
		
	}
	private void _on_zamknute_dvere()
	{
		GD.Print("Sakra, je zamčeno!");
		
	}
	
}
