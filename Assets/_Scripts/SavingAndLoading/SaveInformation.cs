using UnityEngine;
using System.Collections;

public class SaveInformation
{
	public static void SaveAllInformation()
	{
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformations.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformations.PlayerName);
		PlayerPrefs.SetInt ("PARTYSIZE", GameInformations.PartySize);
		PlayerPrefs.SetInt ("MINIONNUM", GameInformations.MinionNum);
		PlayerPrefs.SetInt ("HANDSIZE", GameInformations.HandSize);
		PlayerPrefs.SetInt ("DECKSIZE", GameInformations.DeckSize);

		PlayerPrefs.SetInt ("MINIONLEVEL", GameInformations.MinionLevel);
		PlayerPrefs.SetString ("MINIONNAME", GameInformations.MinionName);
		PlayerPrefs.SetInt ("ENDURANCE", GameInformations.Endurance);
		PlayerPrefs.SetInt ("SMARTS", GameInformations.Smarts);
		PlayerPrefs.SetInt ("POWER", GameInformations.Power);
		PlayerPrefs.SetInt ("SPEED", GameInformations.Speed);
	}
}
