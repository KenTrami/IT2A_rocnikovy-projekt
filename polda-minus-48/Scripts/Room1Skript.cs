using Godot;
using System;

public partial class Room1Skript : Node

{
	private Label label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		label= GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");
	//Když dědím z Node nemusím mít: Pressed += _nazevtlacitka
	//Když dědím z Button musím mít: Pressed += _nazevtlacitka
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
private void _on_zamknute_dvere()
	{
		label.Text="Sakra, je zamčeno!";
	}
	
	
	

}