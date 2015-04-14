using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseMinionSwarm : BaseMinionClass 
{
	public BaseMinionSwarm()
	{
		ItemName = "GreenSwarm";
		ItemDescription = "A Green Minion Swarm";
		ItemID = Random.Range (1, 101);

		MinionClassName = "Swarm";
		MinionClassDescription = "A swarm of angry and normally not very smart minions";

		Endurance = 7;
		Smarts = 3;
		Power = 5;
		Speed = 10;

		Size = 4;
	}
}
