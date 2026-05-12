using Godot;
using System;

public partial class SebratPravitko : Button
{
	// Called when the node enters the scene tree for the first time.
	private Label label;
	private Panel textPozadi;
	private Label text;
	
	public override void _Ready()
	{
		
		//hlavní text
		label=GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");
		Pressed += _on_sebrat_pravitko_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	bool PravitkoNaStole=true;
	private void _on_sebrat_pravitko_pressed()
	{
		if(!PravitkoNaStole==false){
		label.Text="Pravítko. Beru ho, může se hodit.";
		GetNode<Sprite2D>("/root/Node/Pravítko").Hide(); //.. - zkratka pro node
		}
	}	

}
