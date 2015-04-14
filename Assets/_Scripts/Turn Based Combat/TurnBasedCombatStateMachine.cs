using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour 
{
	private BattleStateStart battleStateStartScript = new BattleStateStart();

	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		CALCMDAMAGE,
		LOSE,
		WIN
	}

	public static BattleStates currentState;


	// Use this for initialization
	void Start () 
	{
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch (currentState) 
		{
		case(BattleStates.START):
			//battleStateStartScript.PrepareBattle();
			break;
		case(BattleStates.PLAYERCHOICE):
			break;
		case(BattleStates.ENEMYCHOICE):
			break;
		case(BattleStates.CALCMDAMAGE):
			break;


		case(BattleStates.LOSE):
			break;
		case(BattleStates.WIN):
			break;
		}
	}
}
