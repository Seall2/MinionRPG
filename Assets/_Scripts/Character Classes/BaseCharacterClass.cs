using UnityEngine;
using System.Collections;

public class BaseCharacterClass
{
	private string characterClassName;
	private string characterClassDescription;
	private string characterClassSex;

	//Number of minion groups you can have out in combat.
	private int partySize;
	//total number of minion you can have in your groups.
	private int minionNum;
	//Number of cards you can hold at once.
	private int handSize;
	//Number of cards in your deck.
	private int deckSize;

	public string CharacterClassName
	{
		get{return characterClassName;}
		set{characterClassName = value;}
	}
	
	public string CharacterClassDescription
	{
		get{return characterClassDescription;}
		set{characterClassDescription = value;}
	}

	public string CharacterClassSex
	{
		get{return characterClassSex;}
		set{characterClassSex = value;}
	}

	//The number of groups(characters/Minions) you can have in combat.
	public int PartySize
	{
		get{return partySize;}
		set{partySize = value;}
	}

	//Number of minions you can distribute between your number of groups. 
	public int MinionNum
	{
		get{return minionNum;}
		set{minionNum = value;}
	}

	public int HandSize
	{
		get{return handSize;}
		set{handSize = value;}
	}

	public int DeckSize
	{
		get{return deckSize;}
		set{deckSize = value;}
	}
}
