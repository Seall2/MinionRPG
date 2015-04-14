using UnityEngine;
using System.Collections;

[System.Serializable]
public class Attack : BaseAbility 
{
	public Attack()
	{
		AbilityName = "Normal Attack";
		AbilityDescription = "A normal attack";
		AbilityID = 1;
		AbilityPower = 10;
		AbilityCost = 2;
	}
}
