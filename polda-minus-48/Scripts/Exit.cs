using Godot;
using System;

public partial class Exit : Button
{
	public static string ISIC;
	private Label label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		label= GetNode<Label>("/root/Chodba/Controls/CanvasLayer/Panel/Label");

		Pressed+=_on_exit_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_exit_pressed()
	{
		if (Inventory.ItemCheck(ISIC) == true)
		{
			label.Text="Ty Bláho! Ty dveře se otevřely.";
			GetNode<Button>("/root/Chodba/Controls/Odejit").Show();
		}
		else
		{
			label.Text="Do pr... Teda do Prahy, je to na kartu, nebo na klíč.";	
		}
		
	}
	private void _on_odejit_pressed(){
	}

}
