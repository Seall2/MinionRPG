using UnityEngine;
using System.Collections;

public class BattleStateStart : MonoBehaviour 
{
	/*private BaseMinionClass newEnemy = new BaseMinionClass ();
	private StatCalculations statCalculationScript = StatCalculations ();
	private BaseMinionClass[] minionTypes = new BaseMinionClass[]{new BaseMinionSwarm(), new BaseMinionBrute(), new BaseMinionLeader(), new BaseMinionBuffer()};
	//private StatCalculations statCalculations = new StateCalculations();
	public void PrepareBattle()
	{
		CreateNewEnemy ();
		//ChooseWhoGoesFirst ();
	}

	private void CreateNewEnemy()
	{
		newEnemy.MinionClassName = minionTypes [Random.Range (0, minionTypes.Length + 1)];
		newEnemy.Endurance = statCalculationScript.CalculateStat(newEnemy.Endurance, StatCalculations.StatType.ENDURANCE, true);
		newEnemy.Smarts = statCalculationScript.CalculateStat(newEnemy.Smarts, StatCalculations.StatType.SMARTS, true);
		newEnemy.Power = statCalculationScript.CalculateStat(newEnemy.Power, StatCalculations.StatType.POWER, true);
		newEnemy.Speed = statCalculationScript.CalculateStat(newEnemy.Speed, StatCalculations.StatType.SPEED, true);
	}

	/*private void ChooseWhoGoesFirst()
	{
		if (GameInformations.speed > newEnemy.Speed) 
		{
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
		}
		if (GameInformations.speed < newEnemy.Speed) 
		{
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
		}

		if (GameInformations.speed == newEnemy.Speed) 
		{
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
		}
	}*/
}
