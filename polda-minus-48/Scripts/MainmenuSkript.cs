using Godot;
using System;

public partial class MainmenuSkript : Control
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
			
			
	    }
	private void _on_button_2_pressed()
	{
		GetNode<VBoxContainer>("/root/Node/Menu/VBoxContainer").Hide();
		GetNode<Panel>("/root/Node/Menu/Nastaveni").Show();
	}
	private void _on_button_3_pressed()
	{
		GetTree().Quit();
		
	}
	private void _on_save_pressed()
	{
		GetNode<VBoxContainer>("/root/Node/Menu/VBoxContainer").Show();
		GetNode<Panel>("/root/Node/Menu/Nastaveni").Hide();
	}
	
}
