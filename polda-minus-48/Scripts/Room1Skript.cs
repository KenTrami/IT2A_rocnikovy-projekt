using Godot;
using System;

public partial class Room1Skript : Node

{
	private Label label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
private void _on_zamknute_dvere()
	{
		GD.Print("Sakra, je zamčeno!");
	}
	
	bool PravitkoNaStole=true;
	private void _on_sebrat_pravitko_pressed()
	{
		if(!PravitkoNaStole==false)
		GD.Print("Pravítko. Beru ho, může se hodit.");
		GetNode<Sprite2D>("../Pravítko").Hide(); //.. - zkratka pro node
	}	
	

}