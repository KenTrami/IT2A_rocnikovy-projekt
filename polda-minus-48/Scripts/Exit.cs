using Godot;
using System;
using System.Net;

public partial class Exit : Button
{
	private Label label;
	private Button endButton;
	private Button exitButton;

	public override void _Ready()
	{
		exitButton = this;
		endButton = GetNode<Button>("/root/Chodba/Controls/END");
		label = GetNode<Label>("/root/Chodba/Controls/CanvasLayer/Panel/Label");

		exitButton.Pressed += _on_exit_pressed;
		endButton.Pressed += _on_end_pressed;
	}

	private void _on_exit_pressed()
	{
		if (Inventory.ItemCheck("ISIC"))
		{
			label.Text = "Špica! Ty slavný smart dveře se otevřely. Mažu na Škroupovu a hurá dom.";
			endButton.Show();
			exitButton.Hide();
		}
		else
		{
			label.Text = "Do pr... Teda do Prahy, je to na kartu, nebo na klíč.";
		}
	}

	private void _on_end_pressed()
	{
		if (!IsInsideTree())
			return;

		GetTree().ChangeSceneToFile("res://Scenes/Ending.tscn");
	}
}
