using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseMinionBuffer : BaseMinionClass
{
	public BaseMinionBuffer()
	{
		ItemName = "GreenBuffer";
		ItemDescription = "A Green Minion Buffer";
		ItemID = Random.Range (1, 101);

		MinionClassName = "Buffer";
		MinionClassDescription = "The buffer is a strange minion has the power to buff and at times debuff other minions even healing them, " +
			"yet they don't seem too be any smarter";
		
		Endurance = 3;
		Smarts = 8;
		Power = 3;
		Speed = 7;
		
		Size = 2;
	}
}
