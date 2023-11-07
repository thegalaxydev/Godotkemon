using Godot;
using System;

public partial class PlayerAnimation : AnimatedSprite2D
{
	string _lastAnimation = "idle";
	public override void _Ready()
	{
		FlipH = true;
		Play("stand_side");
	}

	

	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("move_right"))
		{
			FlipH = true;
			Play("walk_side");
			_lastAnimation = "side";
		}
		else if (Input.IsActionPressed("move_left"))
		{
			FlipH = false;
			Play("walk_side");
			_lastAnimation = "side";
		}
		else if (Input.IsActionPressed("move_down"))
		{
			Play("walk_down");
			_lastAnimation = "down";
		}
		else if (Input.IsActionPressed("move_up"))
		{
			Play("walk_up");
			_lastAnimation = "up";
		}
		else
		{
			Play("stand_" + _lastAnimation);
		}


	}
}
