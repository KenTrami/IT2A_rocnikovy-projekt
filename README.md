# IT2A_rocnikovy-projekt
## Jazyk programu:
- c#
## Programy ve kterých se bude pracovat:
- Visual Studio Code
- Godot engine
- Inkscape

## Plán hry
Hlavní postava se propadne časoprostorem, protože chce zachrání sluchátka svého kamaráda a objeví se ve školní budově nejmenované školy. Hlavní protagonista chce najít sluchátka a odejít z místa ve, kterém se objevil. Háček je ale v tom, že dveře jsou zamčené...

## 15.4.
- Přídání místnosti 1 (Místnost 1 nemá finální podobu)
- Správné nastavení kamery u "Místnosti 1"
- Vytvoření provizorního Main menu
- pokus o zprovoznění tlačítka
## 23.4.
- Přidání provizorních tlačítek (budou později nahrazeny předměty)
- drobná úprava místnosti 1
## 29.4.
- Úprava místnosti 1
- Přidání předmětu
- Vytvoření místa, kde se budou zobrazovat monology postavy
- Organizování souborů a kódu
- Všechna tlačítka nyní píšou text do konzole
## 7.5.
- Některá tlačítka nyní zobrazují text.
## 17.5.
- Všechna tlačítka zobrazují text
## 26.5.
- Místnost 1 je hotová.
- Opravení hitboxů tlačítek v místnosti 1
## 28.5
- Místnost 2 je z 98% hotová
## 30.5.
-Místnost 2 je hotová
-Přidány 3 endingy
-Inventář zobrazuje itemy, které jsou sebrány
-Do některých sekcí byla přidána hudba

## Jak si zahrát tuto hru?

# Návod ke spuštění Godot C# projektu z GitHubu

## 1. Stažení projektu

Otevřete repozitář:
Klikněte na: Code → Download ZIP
Stažený ZIP soubor rozbalte do libovolné složky.

## 2. Instalace Godot .NET

Protože projekt používá jazyk C#, je potřeba použít **Godot .NET** (verzi s podporou C#).

Stáhnout lze z oficiálních stránek:
https://godotengine.org/download
## 3. Instalace .NET SDK
Otevřete příkazový řádek a zadej:
dotnet --version
Pokud se zobrazí číslo verze, máte .NET SDK nainstalované.
Pokud ne, stáhněte jej z: https://dotnet.microsoft.com/download
## 4. Otevření projektu v Godotu

1. Spusťte Godot .NET.
2. Klikněte na tlačítko **Import**.
3. Vyberte soubor: project.godot

4. Potvrďte import projektu.

## 5. Vytvoření C# řešení (pokud je potřeba)
Pokud Godot hlásí problémy s C# projektem:

1. Otevřete projekt.
2. V horním menu klikněte na: Project → Tools → C# → Create C# Solution Godot vytvoří potřebné soubory: NazevProjektu.csproj, NazevProjektu.sln
## 6. Sestavení projektu

V editoru Godotu klikněte na: Build, nebo použijte klávesovou zkratku: Ctrl + Shift + B

Po úspěšném sestavení by se měla zobrazit zpráva: Build succeeded

## 7. Spuštění hry

Klikněte na tlačítko Run Project, nebo stiskněte F5

