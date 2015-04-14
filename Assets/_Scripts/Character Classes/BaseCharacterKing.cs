using UnityEngine;
using System.Collections;

public class BaseCharacterKing : BaseCharacterClass 
{
	public BaseCharacterKing()
	{
		CharacterClassName = "King";
		CharacterClassDescription = "A noble ruler of the land who dont believe his knights is up for this challenge";
		CharacterClassSex = "Male";
		
		PartySize = 4;
		MinionNum = 4;
		HandSize = 3;
		DeckSize = 16;
	}
}
