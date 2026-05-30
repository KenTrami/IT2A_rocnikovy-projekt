using Godot;
using System;

public partial class Odpovedi : Button
{
	private Button good;
	private Button bad1;
	private Button bad2;

	public override void _Ready()
	{
		good = GetNode<Button>("/root/Endings/GoodEnding");
		bad1 = GetNode<Button>("/root/Endings/BadEnding1");
		bad2 = GetNode<Button>("/root/Endings/BadEnding2");

		good.Pressed += _on_good_ending_pressed;
		bad1.Pressed += _on_bad_ending_1_pressed;
		bad2.Pressed += _on_bad_ending_2_pressed;
	}

	private void _on_good_ending_pressed()
	{
		if (!IsInsideTree()) return;
		GetTree().ChangeSceneToFile("res://Scenes/GoodEnding.tscn");
	}

	private void _on_bad_ending_1_pressed()
	{
		if (!IsInsideTree()) return;
		GetTree().ChangeSceneToFile("res://Scenes/bad_ending_1.tscn");
	}

	private void _on_bad_ending_2_pressed()
	{
		if (!IsInsideTree()) return;
		GetTree().ChangeSceneToFile("res://Scenes/bad_ending_2.tscn");
	}
}
