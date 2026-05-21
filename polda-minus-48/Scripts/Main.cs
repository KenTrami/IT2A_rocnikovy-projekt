using Godot;
using System;

public partial class Main : Node
{
	private Panel inventoryUI;
	private Panel pozastavitHru;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		inventoryUI=GetNode<Panel>("Controls/InventoryUI");
		pozastavitHru=GetNode<Panel>("Controls/PozastavitHru");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	 public override void _Input(InputEvent @event) //InputEvent bere keybind
	{
		if (@event.IsActionPressed("inventory"))
		{
			inventoryUI.Visible = !inventoryUI.Visible;
		}
		if (@event.IsActionPressed("stop"))
		{
			pozastavitHru.Visible=!pozastavitHru.Visible;
		}
	}

	
}
