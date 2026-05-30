using System.Security.Cryptography.X509Certificates;
using Godot;

public partial class Kod : LineEdit
{
    public static string ISIC;
    private Label label;
    public override void _Ready()
    {
        TextChanged += OnTextChanged;
        TextSubmitted += OnTextChanged;

        label = GetNode<Label>("/root/Chodba/Controls/CanvasLayer/Panel/Label");

        Text = "";
    }

    private void OnTextChanged(string newText)
    {
        // povolí pouze čísla
        string pouzeCisla = "";

        foreach (char c in newText)
        {
            if (char.IsDigit(c))
                pouzeCisla += c;
        }

        Text = pouzeCisla;
        CaretColumn = Text.Length;

        if (Text.Length == 4)
        {
            if (Text == "5815")
            {
                label.Text = "Výborně trezůrek otevřený. Kdo ví co se mu stalo, že má ISIC tady. No počkat! Ten zmetek si tu schovává Šeňovi sluchátka. Zlodějíček jeden. No nic beru Sluchátka a ISIC. ";
                Inventory.Inventar.Add("ISIC");
                Inventory.Inventar.Add("SenaSluchatka");
                GetNode<TextureRect>("/root/Chodba/Controls/InventoryUI/isic").Show(); //zobrazení v inventáři
            }
            else
            {
                label.Text = "Tak to nevyšlo.";
            }

            GetNode<Panel>("/root/Chodba/Controls/Panel").Hide();

            Clear(); // smazání políčka
        }
    }
}