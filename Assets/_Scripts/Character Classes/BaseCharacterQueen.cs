using UnityEngine;
using System.Collections;

public class BaseCharacterQueen : BaseCharacterClass 
{
	public BaseCharacterQueen()
	{
		CharacterClassName = "Queen";
		CharacterClassDescription = "The Queen of the land, although she trust her husband she thinks this require a queens touch";
		CharacterClassSex = "Female";
		
		PartySize = 3;
		MinionNum = 5;
		HandSize = 5;
		DeckSize = 12;
	}
}
