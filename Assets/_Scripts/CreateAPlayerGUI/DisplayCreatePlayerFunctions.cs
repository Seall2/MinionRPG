using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions
{
	private int classSelection;
	private string[] classSelectionNames = new string[] {"Overlord", "King", "Queen"};
	private string playerName = "";
	//private CreateMinion tempMinion = new CreateMinion();

	public void DisplayClassSelections()
	{
		classSelection = GUI.SelectionGrid (new Rect (50, 50, 250, 300), classSelection, classSelectionNames, 2);
		GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
		GUI.Label(new Rect(450, 100, 300, 300), FindClassStats(classSelection));
	}

	public void DisplayChoice()
	{
		GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
		GUI.Label(new Rect(450, 100, 300, 300), FindClassStats(classSelection));
	}

	private string FindClassDescription(int classSelection)
	{
		if (classSelection == 0) 
		{
			BaseCharacterClass tempClass = new BaseCharacterOverlord();
			return tempClass.CharacterClassDescription;
		}

		if (classSelection == 1) 
		{
			BaseCharacterClass tempClass = new BaseCharacterKing();
			return tempClass.CharacterClassDescription;
		}

		if (classSelection == 2) 
		{
			BaseCharacterClass tempClass = new BaseCharacterQueen();
			return tempClass.CharacterClassDescription;
		}

		return "";
	}

	private string FindClassStats(int classSelection)
	{
		if (classSelection == 0) 
		{
			BaseCharacterClass tempClass = new BaseCharacterOverlord();
			string tempStats = "Party Size: " + tempClass.PartySize + "\n" + "Number of minions: " + tempClass.MinionNum +
				"\n" + "Hand size: " + tempClass.HandSize + "\n" + "Deck size: " + tempClass.DeckSize;
			return tempStats;
		}

		if (classSelection == 1) 
		{
			BaseCharacterClass tempClass = new BaseCharacterKing();
			string tempStats = "Party Size: " + tempClass.PartySize + "\n" + "Number of minions: " + tempClass.MinionNum +
				"\n" + "Hand size: " + tempClass.HandSize + "\n" + "Deck size: " + tempClass.DeckSize;
			return tempStats;
		}

		if (classSelection == 2) 
		{
			BaseCharacterClass tempClass = new BaseCharacterQueen();
			string tempStats = "Party Size: " + tempClass.PartySize + "\n" + "Number of minions: " + tempClass.MinionNum +
				"\n" + "Hand size: " + tempClass.HandSize + "\n" + "Deck size: " + tempClass.DeckSize;
			return tempStats;
		}
		return "";
	}

	public void DisplayFinalSetup()
	{
		GUI.Label(new Rect (20, 10, 100, 35), "Name: ");
		playerName = GUI.TextArea (new Rect (60, 10, 100, 25), playerName, 25);
	}

	private void ChooseClass(int classSelection)
	{
		if (classSelection == 0) 
		{
			GameInformations.PlayerClass = new BaseCharacterOverlord();
		}

		if (classSelection == 1) 
		{
			GameInformations.PlayerClass = new BaseCharacterKing();
		}

		if (classSelection == 2) 
		{
			GameInformations.PlayerClass = new BaseCharacterQueen();
		}
	}

	public void DisplayMainItems()
	{
		GUI.Label (new Rect (Screen.width / 2, 20, 250, 250), "Create new player");
		if (CreateAPlayerGUI.currentstate != CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) 
		{
			if (GUI.Button (new Rect (470, 370, 50, 50), "Next")) 
			{
				ChooseClass (classSelection);
				CreateAPlayerGUI.currentstate = CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP;  
			}
		} 
		else if (CreateAPlayerGUI.currentstate == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) 
		{
			if(GUI.Button(new Rect(470, 370, 50, 50), "Finish"))
			{
				SaveInformation.SaveAllInformation();
				//CreateMinion.CreateYourMinion();
				Application.LoadLevel("TestWalk");
			}
		}

		if(CreateAPlayerGUI.currentstate != CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION)
		{
			if (GUI.Button (new Rect (400, 370, 50, 50), "Back")) 
			{
				if(CreateAPlayerGUI.currentstate == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP)
				{
					ChooseClass (classSelection);
					CreateAPlayerGUI.currentstate = CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION;
				}  
			}
		}
	}
}
