using UnityEngine;
using System.Collections;

public class BaseCharacterOverlord : BaseCharacterClass 
{
	public BaseCharacterOverlord()
	{
		CharacterClassName = "Overlord";
		CharacterClassDescription = "A powerful and evil ruler whos only wish is destructions";
		CharacterClassSex = "Male";

		PartySize = 3;
		MinionNum = 6;
		HandSize = 3;
		DeckSize = 14;
	}
}
