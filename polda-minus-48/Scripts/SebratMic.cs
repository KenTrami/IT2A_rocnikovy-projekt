using Godot;
using System;
using System.Runtime.CompilerServices;


public partial class SebratMic : Button
{
	public static string mic;
	private Label label;
public override void _Ready()
	{
		
		//hlavní text
		label=GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");
		Pressed += _on_sebrat_mic_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public static bool MicNaZemi=true;
	private void _on_sebrat_mic_pressed()
	{
		if(!MicNaZemi==false){
		label.Text="A mám tě! Pojď k tatínkovi!";
		GetNode<Sprite2D>("/root/Node/BasketbalovýMíč").Hide(); //.. - zkratka pro node
		Inventory.ItemGet(mic);
		//Sprite2D pravitkoItem =GetNode<Sprite2D>("/root/Node/Pravítko");
		MicNaZemi=false;
		}
		else
		{
			label.Text="Na zemi už nic není.";
		}
	}	
}
