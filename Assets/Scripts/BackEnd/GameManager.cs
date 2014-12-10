
using UnityEngine;
using System.Collections;

static public class GameManager
{
    //publics
	public static int PlayersInLobby;
	public static int PlayersTurn;
    //privates
	private static ArrayList Players;


	static public void Init()
	{
		Players = new ArrayList();
		PlayersInLobby = 0;
		PlayersTurn = 0;
	}

	static public bool AddPlayer(Player p)
	{
		if(Players.Count == 0)
		{
			Players.Add(p);
			return true;
		}
		foreach(Player j in Players)
		{
			if(Equals(p,j))
			{
				Debug.Log("player already exists");
				return false;
			}
		}
		Players.Add (p);
		PlayersInLobby++;
		return true;
	}
    // Use this for initialization
    public static void GameLoop()
    {
		PlayerTurn((Player)Players[PlayersTurn]);
    }

    private static void PlayerTurn(Player p)
    {
		if(Input.GetMouseButtonDown (0))
		{
			p.UpdatePlyer();
			PlayersTurn++;
			PlayersTurn = PlayersTurn%(PlayersInLobby+1);
		}
    }
}
