using Godot;
using System;

public partial class GameManager : Node
{

	[Export]
	private CharacterBody2D _player;
	public CharacterBody2D Player {get => _player;}

	private int _tallGrassEncounterRate = 10;
	public int TallGrassEncounterRate {get => _tallGrassEncounterRate; set => _tallGrassEncounterRate = value;}
	
	private int _weather = 0;
	public int Weather {get => _weather; set => _weather = value;}

	private int _time = 0;
	public int Time {get => _time; set => _time = value;}

	private int _day = 0;
	public int Day {get => _day; set => _day = value;}

	// some global stuff


	private static GameManager _instance;
	public static GameManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new GameManager();
			}
			return _instance;
		}
	}

	public override void _Ready()
	{
		_instance = this;
	}


	public void StartEncounter()
	{
		GD.Print("Encounter Started");
	}

	public void OnPlayerEnteredTallGrass(Node2D body)
	{
		if (new Random().Next(0, 100) < TallGrassEncounterRate)
		{
			StartEncounter();
		}
	}
}
