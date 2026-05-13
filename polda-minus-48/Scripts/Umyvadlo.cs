using Godot;
using System;

public partial class Umyvadlo : Button
{
	private Label label;
	private Panel textPozadi;
	private Label text;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		label=GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");
		Pressed+= _on_umyvadlo_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_umyvadlo_pressed()
	{
		label.Text="Obyčejné umyvadlo. Když jsem chodil na základku, tak nám občas tekla žlutá voda.";
	}

	
}
