using Godot;
using System;

public partial class PodivatSeZaTabuli : Button
{
	private Label label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		label=GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");
		
		
		Pressed += _on_podivat_se_za_tabuli_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_podivat_se_za_tabuli_pressed()
	{
		
		label.Text="Jé hele míček! Škoda že na něho nedošáhnu.";

	}
}
