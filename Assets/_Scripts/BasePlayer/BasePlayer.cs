using UnityEngine;
using System.Collections;

public class BasePlayer 
{
	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;

	//Total Number of Groups(Characters) you can have.
	private int partySize;
	//total number of minion you can have in your groups overall.
	private int minionNum;
	//Number of cards you can hold at once.
	private int handSize;
	//Number of cards in your deck.
	private int deckSize;

	public string PlayerName
	{
		get{return playerName;}
		set{ playerName = value;}
	}

	public int PlayerLevel
	{
		get{return playerLevel;}
		set{ playerLevel = value;}
	}

	public BaseCharacterClass PlayerClass
	{
		get{return playerClass;}
		set{ playerClass = value;}
	}

	public int PartySize
	{
		get{return partySize;}
		set{ partySize = value;}
	}

	public int MinionNum
	{
		get{return minionNum;}
		set{ minionNum = value;}
	}

	public int HandSize
	{
		get{return handSize;}
		set{ handSize = value;}
	}

	public int DeckSize
	{
		get{return deckSize;}
		set{ deckSize = value;}
	}
}
