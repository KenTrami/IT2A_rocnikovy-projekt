using Godot;
using System;

public partial class Nastenky : Button
{
	private Label label;
	public int RadimSkrin=0; //pomocná proměnná
	public int kytka=0; //kolikrát jsme klikli na kytku
	public static string RadimKlice;
	public static bool RadimOdemceno=false; //stav zámku radimovi skříňky
	public static bool radim = false; //určuje jestli víme o radimovi informace
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//buttony nastenek
		var NastenkaStudentu=GetNode<Button>("/root/Chodba/Controls/NastenkaStudentu");
		var NastenkaStudentu2=GetNode<Button>("/root/Chodba/Controls/NastenkaStudentu2");
		var NastenkaPravidel=GetNode<Button>("/root/Chodba/Controls/NastenkaPravidel");
		//Kytka
		var Kytka=GetNode<Button>("/root/Chodba/Controls/Květináč");
		//buttony skrinek
		var Pepa=GetNode<Button>("/root/Chodba/Controls/Pepa");
		var Ela=GetNode<Button>("/root/Chodba/Controls/Ela");
		var Erik=GetNode<Button>("/root/Chodba/Controls/Erik");
		var Radim=GetNode<Button>("/root/Chodba/Controls/Radim");
		var Eva=GetNode<Button>("/root/Chodba/Controls/Eva");
		var Ema=GetNode<Button>("/root/Chodba/Controls/Ema");
		var Jakub=GetNode<Button>("/root/Chodba/Controls/Jakub");
		var Jan=GetNode<Button>("/root/Chodba/Controls/Jan");

		


		label= GetNode<Label>("/root/Chodba/Controls/CanvasLayer/Panel/Label");
		//propojení nastenek
		NastenkaStudentu.Pressed+= _on_nastenka_studentu_pressed;
		NastenkaStudentu2.Pressed+= _on_nastenka_studentu_2_pressed;
		NastenkaPravidel.Pressed+= _on_nastenka_pravidel_pressed;
		//propojeni kytky
		Kytka.Pressed+= _on_květináč_pressed;
		//propojeni skrine
		Pepa.Pressed+=_on_pepa_pressed;
		Ela.Pressed+=_on_ela_pressed;
		Erik.Pressed+=_on_erik_pressed;
		Radim.Pressed+=_on_radim_pressed;
		Eva.Pressed+=_on_eva_pressed;
		Ema.Pressed+=_on_ema_pressed;
		Jakub.Pressed+=_on_jakub_pressed;
		Jan.Pressed+=_on_jan_pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	//Nastenky
	private void _on_nastenka_studentu_pressed()
	{
		label.Text="Nástěnka studentů, copak tu je zajímavého? Nový vedoucí IT sekce pan Vojtík... Nové žaluzie... Nová paní uklízečka... ";
	}
	private void _on_nastenka_studentu_2_pressed()
	{
		label.Text="Co to tu je za nápis? radym si zabouchl klýče a druhí klýče stratyl Ydyjot! Vypadá to tak, že ten kdo to psal není nejostřejší tužka v penále.";
		radim=true;
		kytka=1;
	}
	private void _on_nastenka_pravidel_pressed()
	{
		label.Text="Hmmm. Nástěnka pravidel. Co to tu máme? Nezájem, nezájem, keci keci... Pravidlo číslo 6. Nosit si svoji ISIC kartu. Pokud ji žák zapomene musí se zapsat na vrátnici";
	}
	

	//skrinky
	private void _on_pepa_pressed()
	{
		label.Text="Skříňka Pepy";	
	}

	private void _on_ela_pressed()
	{
		label.Text="Skříňka Ely.";	
	}
	private void _on_erik_pressed()
	{
		label.Text="Skříňka Erika.";	
	}
	private void _on_radim_pressed()
{
	if (radim == false)
	{
		label.Text = "Skříňka Radima";
		return;
	}

	if (!Inventory.ItemCheck("RadimKlice"))
	{
		label.Text = "Hele nepsali něco o něm na nástěnce? No jistě! Ten Radym je ve skutečnosti Radim.";
		return;
	}

	if (RadimOdemceno == false && RadimSkrin == 0)
	{
		label.Text = "Radim tu má opravdu zabouchnuté klíče. Ale karta nikde není. No to si snad dělá srandu on tu má mini trezor.";
		RadimOdemceno = true;
		RadimSkrin = 1;
		kytka=0;
		return;
	}

	if (RadimOdemceno == true && RadimSkrin == 1)
	{
		GetNode<Panel>("/root/Chodba/Controls/Panel").Show();
		label.Text = "Takže čtyř-číselný kód to po nás chce... Ještě, že to nechce po mě otisk, protože nevěřím tomu, že by Radimovi spolužáci byli tak zlí, abych tu někde našel jeho prst.";
		kytka=2;
		return;
	}

	
}
	private void _on_eva_pressed()
	{
		label.Text="Skříňka Evy.";	
	}
	private void _on_ema_pressed()
	{
		label.Text="Skříňka Emy.";	
	}
	private void _on_jakub_pressed()
	{
		label.Text="Skříňka Jakuba.";	
	}
	private void _on_jan_pressed()
	{
		label.Text="Skříňka Honzy.";	
	}
	//Kytka
	private void _on_květináč_pressed()
{
	if (radim == false || kytka == 0)
	{
		label.Text = "Klasická umělotina. Nejlepší květina poměr cena výkon.";
		kytka = 1;
		return;
	}

	else if (radim == true && kytka > 1)
	{
		label.Text = "Ta kytka je jak koš v každý dobrý point and click adventůře. Vždycky tu je co najít. Například je tu na listu napsáno: 5815";
		return;
	}

	else if (radim == true && kytka == 1)
	{
		if (!Inventory.ItemCheck("RadimKlice"))
		{
			label.Text = "Asi toho Radima nemají rádi. Když mu jeho ztracené klíče schovali sem.";
			Inventory.Inventar.Add("RadimKlice");
			GetNode<TextureRect>("/root/Chodba/Controls/InventoryUI/radimklice").Show(); //zobrazení v inventáři
		}
		return;
	}
}
}
