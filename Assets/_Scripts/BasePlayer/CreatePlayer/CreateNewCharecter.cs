using UnityEngine;
using System.Collections;

public class CreateNewCharecter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isOverlordClass;
	private bool isKingClass;
	private bool isQueenClass;
	private string playerName = "Enter Name";

	// Use this for initialization
	void Start () 
	{
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		playerName = GUILayout.TextArea (playerName, 15);
		isOverlordClass = GUILayout.Toggle (isOverlordClass, "Overlord");
		isKingClass = GUILayout.Toggle (isKingClass, "King");
		isQueenClass = GUILayout.Toggle (isQueenClass, "Queen");

		if (GUILayout.Button ("Create")) 
		{
			if(isOverlordClass)
			{
				newPlayer.PlayerClass = new BaseCharacterOverlord();
			}
			else if(isKingClass)
			{
				newPlayer.PlayerClass = new BaseCharacterKing();
			}
			else if(isQueenClass)
			{
				newPlayer.PlayerClass = new BaseCharacterQueen();
			}

			newPlayer.PlayerLevel = 1;
			newPlayer.PartySize = newPlayer.PlayerClass.PartySize;
			newPlayer.MinionNum = newPlayer.PlayerClass.MinionNum;
			newPlayer.HandSize = newPlayer.PlayerClass.HandSize;
			newPlayer.DeckSize = newPlayer.PlayerClass.DeckSize;
			newPlayer.PlayerName = playerName;
			StoreNewPlayerInfo();
			SaveInformation.SaveAllInformation();
		}

		if(GUILayout.Button("Load"))
		{
			Application.LoadLevel("Test");
		}
	}

	private void StoreNewPlayerInfo()
	{
		GameInformations.PlayerName = newPlayer.PlayerName;
		GameInformations.PlayerLevel = newPlayer.PlayerLevel;
		GameInformations.PartySize = newPlayer.PartySize;
		GameInformations.MinionNum = newPlayer.MinionNum;
		GameInformations.HandSize = newPlayer.HandSize;
		GameInformations.DeckSize = newPlayer.DeckSize;
	}
}
