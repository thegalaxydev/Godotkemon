using Godot;
using System;
public partial class PlayerMovement : CharacterBody2D
{
	
	[Export] 
	private int _speed = 2;


	public override void _Ready()
	{
		FloorSnapLength = 16;

	}

	public void OnAreaEntered(Node2D body)
	{
		GD.Print("Entered");
	}

	public override void _Process(double delta)
	{
		Vector2 velocity = new Vector2();
		if (Input.IsActionPressed("move_right"))
		{
			velocity.X += 1;
		}
		if (Input.IsActionPressed("move_left"))
		{
			velocity.X -= 1;
		}
		if (Input.IsActionPressed("move_down"))
		{
			velocity.Y += 1;
		}
		if (Input.IsActionPressed("move_up"))
		{
			velocity.Y -= 1;
		}
		velocity = velocity.Normalized() * MathF.Ceiling(_speed * (float)delta);
		MoveAndCollide(velocity);
	}
}
