using Godot;
using System;

public partial class Nastenky : Button
{
	private Label label;
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
		label.Text="Nástěnka studentů, copak tu je zajímavého? Nový vedoucí IT sekce pan Vojtík... Nové žaluzie... Nový paní uklížečka... ";
	}
	private void _on_nastenka_studentu_2_pressed()
	{
		label.Text="co to tu je za nápis? radym si zabouchl klýče a druhí klýče stratyl! Vypadá to tak, že ten kdo to psal není nejostřejší tužka v penále.";
		radim=true;
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
			label.Text="Skříňka Radima";	
		}
		else if (radim == true && Inventory.ItemCheck(RadimKlice)==false)
		{
			label.Text="Hele nepsali něco o něm na nástěnce? No jistě! Ten radym je ve skutečnosti Radim. Měl by se ten jouda naučit psát.";
		}
		else if (Inventory.ItemCheck(RadimKlice) == true && RadimOdemceno==false)
		{
			label.Text="Radim tu má opravdu zabouchnuté klíče. Ale kartu nikde nevidím. No to si snad dělá srandu on tu má mini trezor.";
			RadimOdemceno=true;
		}
		else if (Inventory.ItemCheck(RadimKlice) ==true && RadimOdemceno==true)
			{
				
				GetNode<Panel>("/root/Chodba/Controls/Panel").Show();
				label.Text="Takže čtyř-číselný kód to po nás chce... Ještě, že to nechce po mě otisk, protože nevěřím tomu, že by Radimovi spolužáci byli tak zlí, že bych tu někde našel jeho prst.";

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
		if (radim == false || kytka==0)
		{
			label.Text="Klasická umělotina. Nejlepší květina poměr cena výkon.";
			kytka++;	
		}
		else if (radim == true && kytka>0)
		{
			label.Text="Asi toho Radima nemají rádi. Když mu jeho ztracené klíče schovali sem.";
			Inventory.Inventar.Add(RadimKlice);
		}
		
	}
}
