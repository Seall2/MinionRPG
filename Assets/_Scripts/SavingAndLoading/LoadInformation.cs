using UnityEngine;
using System.Collections;

public class LoadInformation 
{
	public static void LoadAllInformation()
	{
		GameInformations.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformations.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformations.PartySize = PlayerPrefs.GetInt ("PARTYSIZE");
		GameInformations.MinionNum = PlayerPrefs.GetInt ("MINIONNUM");
		GameInformations.HandSize = PlayerPrefs.GetInt ("HANDSIZE");
		GameInformations.DeckSize = PlayerPrefs.GetInt ("DECKSIZE");

	}
}
