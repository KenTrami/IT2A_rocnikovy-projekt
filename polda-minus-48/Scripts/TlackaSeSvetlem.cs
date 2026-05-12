using Godot;
using System;

public partial class TlackaSeSvetlem : Button
{
	private Label label;
	private Sprite2D sprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		

		//hlavní text
		var ZhasnoutSvetlo= GetNode<Button>("../ZhasnoutSvetlo");
		var PodivneSviticiZarivka=GetNode<Button>("../PodivneSviticiZarivka");
		var PodivatSeZOkna=GetNode<Button>("../PodivatSeZOkna");
		label=GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");
		//text se přidá do labelu po stisknutí tlačítka
		ZhasnoutSvetlo.Pressed +=  _on_zhasnout_svetlo_pressed;
		PodivneSviticiZarivka.Pressed += _on_podivne_svitici_zarivka_pressed;
		PodivatSeZOkna.Pressed += _on_podivat_se_z_okna_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	} 
	bool zhasnuto=true;
	private void _on_zhasnout_svetlo_pressed()
	{
		
		if (!zhasnuto == false)
		{
			GetNode<Sprite2D>("/root/Node/Room1_Rosviceno").Hide();	//.. - zkratka pro node
			label.Text="Konečne ty zářivky nesvítí jak stroboskop.";
			zhasnuto=false;
		}
		else
		{
			label.Text="Nevím proč bych to zapínal.";
		}

	}
	private void _on_podivne_svitici_zarivka_pressed()
	{
		if (!zhasnuto == false)
		{
			label.Text="Ta zářivka je ňáká divná. Jak kdyby v ní něco bylo.";	
		}
		else
		{
			label.Text="Hele Klíče!. Musím se pro ně nějak dostat.";
		}
		
	}
	
	private void _on_podivat_se_z_okna_pressed()
		{
			if (!zhasnuto == false)
			{
				
				label.Text="Kdyby to světlo tolik nesvítilo, tak možná něco viděl.";
			}
			else
			{
				label.Text="Hm... Tak tudy to nepude. Za prvé tam jsou venkovní žaluzie a za druhé tam je díra jak dopr.. teda do propasti hehe.";
			}
		}
}
