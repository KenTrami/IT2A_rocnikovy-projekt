using Godot;
using System;
using System.Collections.Generic;
using System.Formats.Tar;

public partial class TlackaSeSvetlem : Button
{
	private bool lepidlo=true;
	private bool LihNaklici;
	public string pravitko;
	public string klic;
	public string mic;
	private Label label;
	private Sprite2D sprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		

		//získání tlačítek
		var ZhasnoutSvetlo= GetNode<Button>("../ZhasnoutSvetlo");
		var PodivneSviticiZarivka=GetNode<Button>("../PodivneSviticiZarivka");
		var PodivatSeZOkna=GetNode<Button>("../PodivatSeZOkna");
		var HoditMic=GetNode<Button>("/root/Node/Controls/HoditMic");
		var ZamknuteDvere=GetNode<Button>("/root/Node/Controls/ZamceneDvere");
		var Umyvadlo=GetNode<Button>("/root/Node/Controls/Umyvadlo");
		var Lih=GetNode<Button>("/root/Node/Controls/Lih");
		label=GetNode<Label>("/root/Node/Controls/CanvasLayer/Panel/Label");

		//text se přidá do labelu po stisknutí tlačítka
		ZhasnoutSvetlo.Pressed +=  _on_zhasnout_svetlo_pressed;
		PodivneSviticiZarivka.Pressed += _on_podivne_svitici_zarivka_pressed;
		PodivatSeZOkna.Pressed += _on_podivat_se_z_okna_pressed;
		HoditMic.Pressed+= _on_hodit_mic_pressed;
		ZamknuteDvere.Pressed+= _on_zamcene_dvere_pressed;
		Umyvadlo.Pressed+= _on_umyvadlo_pressed;
		Lih.Pressed+= _on_lih_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	} 
	//Vypínače
	bool zhasnuto=true;
	private void _on_zhasnout_svetlo_pressed()
	{
		if (!zhasnuto == false)
		{
			GetNode<Sprite2D>("/root/Node/Klic").Show();
			GetNode<Sprite2D>("/root/Node/Room1_Rosviceno").Hide();
			GetNode<Sprite2D>("/root/Node/Lih").Show();
			label.Text="Konečne ty zářivky nesvítí jak stroboskop.";
			zhasnuto=false;
		}
		else
		{
			label.Text="Nevím proč bych to zapínal.";
		}

	}
	//Zářivka
	private void _on_podivne_svitici_zarivka_pressed()
	{	//roznuto
		if (!zhasnuto == false)
		{
			label.Text="Ta zářivka je ňáká divná. Jak kdyby v ní něco bylo.";
		}
		//zhasnuto
		else
		{
			label.Text="Hele Klíče! Musím se pro ně nějak dostat.";
			
		}
		
	}
	//Okno	
	private void _on_podivat_se_z_okna_pressed()
		{	//roznuto
			if (!zhasnuto == false)
			{
				
				label.Text="Kdyby to světlo tolik nesvítilo, tak bych možná něco viděl.";
			}
			//zhasnuto
			else
			{
				label.Text="Hm... Tak tudy to nepude. Za prvé tam jsou venkovní žaluzie a za druhé tam je díra jak dopr.. teda do propasti hehe.";
				
			}
		}
	//Hod míče
	private void _on_hodit_mic_pressed()
	{	//mam mic a je zhasnuto
		if (Inventory.ItemCheck("mic")==!false && zhasnuto==false)
		{
			label.Text="Trefa! A klíče jsou venku. Stejně ta zářivka potřebovala vyměnit. Co s tím klíčem do háje dělali?! Však je komplet od lepidla!";
			GetNode<Sprite2D>("/root/Node/MřížkaZeZářivky").Show();
			GetNode<Sprite2D>("/root/Node/Klic").Hide();
			GetNode<Sprite2D>("/root/Node/Room_1").Hide();
			Inventory.Inventar.Add("klic");
			GetNode<TextureRect>("/root/Node/Controls/InventoryUI/klic").Show(); //zobrazení v inventáři
			
		}
		//mam mic a je roznuto
		else if (Inventory.ItemCheck("mic")==!false && !zhasnuto == false)
		{
			label.Text="Tyto světla svítí jako stroboskopy a vypalují mi oči.";
		}
		else
		{
			label.Text="Pro ty klíče se musím nějak dostat.";
		}
	
	}
	

	//Dveře
	private void _on_zamcene_dvere_pressed()
	{
		if(Inventory.ItemCheck("klic")==true && lepidlo==false){
			label.Text="Hurá! Dveře odemčeny! Mizím odsud.";
			GetNode<Button>("/root/Node/Controls/ZamceneDvere").Hide();
			GetNode<Button>("/root/Node/Controls/Odejit").Show();
		}
		else if(Inventory.ItemCheck("klic")==true && lepidlo == true)
		{
			label.Text="Ten klíč je příšerně ulepenej. Potřebuju to svinstvo z toho nějak dostat.";
		}
		else
		{
			label.Text="Sakra je zamčeno!";	
		}
		
	}
	//Umyvadlo
	private void _on_umyvadlo_pressed()
	{
		if(Inventory.ItemCheck("klic")==true && LihNaklici== true)
		{
			label.Text="Paráda! To svinstvo z toho slezlo.";
			lepidlo=false;
		}
		else if(Inventory.ItemCheck("klic")==true && LihNaklici == false)
		{
			label.Text="To svinstvo z toho nechce slézt.";
		}
		else{
		label.Text="Obyčejné umyvadlo. Když jsem chodil na základku, tak nám občas tekla žlutá voda.";
		}
	}
	//líh
	private void _on_lih_pressed()
	{
		if (Inventory.ItemCheck("klic") == true && lepidlo==true)
		{
			label.Text="Nastříkal jsem trochu líhu na klíč";
			LihNaklici=true;
		}
		else
		{
			label.Text="Obyčejný líh. Ten zatím brát nebudu.";
		}
	}
	
}
