using UnityEngine;
using System.Collections;

public class GameClient : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		GameManager.Init ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GameManager.PlayersInLobby > 0)
		{
			GameManager.GameLoop ();
		}
	}
	void OnGUI()
	{
		GUI.Button(new Rect(10,10,200 ,20),"Players Turn" + (GameManager.PlayersTurn+1).ToString());
	}
}
