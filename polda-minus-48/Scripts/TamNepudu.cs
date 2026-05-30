using Godot;
using System;

public partial class TamNepudu : Button
{
	private Label label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//buttony
		var OO9=GetNode<Button>("/root/Chodba/Controls/trida009");
		var OO8=GetNode<Button>("/root/Chodba/Controls/trida008");
		var OO7=GetNode<Button>("/root/Chodba/Controls/trida007");
		var OO6=GetNode<Button>("/root/Chodba/Controls/trida006");
		
		label= GetNode<Label>("/root/Chodba/Controls/CanvasLayer/Panel/Label");

		OO9.Pressed+= _on_trida_009_pressed;
		OO8.Pressed+= _on_trida_008_pressed;
		OO7.Pressed+= _on_trida_007_pressed;
		OO6.Pressed+= _on_trida_006_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.

	private void _on_trida_009_pressed()
	{
		label.Text="Odtud jsem přišel a zpět tam už nepůjdu.";
	}
	private void _on_trida_008_pressed()
	{
		label.Text="Je to zamčené a dobívat se tam nebudu.";
	}
	private void _on_trida_007_pressed()
	{
		label.Text="Je to zamčené a dobívat se tam nebudu.";
	}
	private void _on_trida_006_pressed()
	{
		label.Text="Je to zamčené a dobívat se tam nebudu.";
	}
}
