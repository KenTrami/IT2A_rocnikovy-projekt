using Godot;
using System;

public partial class PodivatSeZaTabuli : Button
{
	int mic=0;
	public static string pravitko;
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
		
		if (Inventory.ItemCheck("pravitko")==true &&mic==0)
		{	
			label.Text="A je to! Vyštoural jsem ho ven";
			GetNode<Sprite2D>("/root/Node/BasketbalovýMíč").Show();
			GetNode<Button>("/root/Node/Controls/SebratMic").Show();
			GetNode<Button>("/root/Node/Controls/PodivatSeZaTabuli").Hide();
		}
		else
		{
			label.Text="Jé hele míček! Škoda že za tu tabulu nedošáhnu.";	
		}
		
		

	}
}
