using Godot;
using System;

public partial class Room1 : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_zamknute_dvere()
	{
		GD.Print("Sakra, je zamčeno!");
		
	}
	bool zhasnuto=true;
	private void _on_zhasnout_svetlo_pressed()
	{
		
		if (!zhasnuto == false)
		{
			GetNode<Sprite2D>("../Room1Rosviceno").Hide();	//.. - zkratka pro node
			GD.Print("Konečne ty zářivky nesvítí jak stroboskop.");
			zhasnuto=false;
		}
		else
		{
			GD.Print("Nevím proč bych to zapínal.");
		}

	}
	private void _on_podivat_se_za_tabuli_pressed()
	{
		GD.Print("Jé hele míček! Škoda že na něho nedošáhnu.");
	}
	bool PravitkoNaStole=true;
	private void _on_sebrat_pravitko_pressed()
	{
		if(!PravitkoNaStole==false)
		GD.Print("Pravítko. Beru ho, může se hodit.");
		GetNode<Sprite2D>("../Pravítko").Hide(); //.. - zkratka pro node
	}	
	private void _on_podivne_svitici_zarivka_pressed()
	{
		if (!zhasnuto == false)
		{
			GD.Print("Ta zářivka je ňáká divná. Jak kdyby v ní něco bylo.");	
		}
		else
		{
			GD.Print("Hele Klíče!. Musím se pro ně nějak dostat.");
		}
		
	}
	private void _on_podivat_se_z_okna_pressed()
	{
		if (!zhasnuto == false)
		{
			GD.Print("Kdyby to světlo tolik nesvítilo, tak možná něco viděl.");
		}
		else
		{
			GD.Print("Hm... Tak tudy to nepude. Za prvé tam jsou venkovní žaluzie a za druhé tam je díra jak dopr.. teda do propasti hehe.");
		}
	}


}