using Godot;
using System;
using System.Diagnostics;

public partial class GrassCollision : Area2D
{
	public void OnAreaEntered(Node2D body)
	{
		Debug.WriteLine("Entered");
	}
}
