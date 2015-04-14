using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseMinionLeader : BaseMinionClass
{
	public BaseMinionLeader()
	{
		ItemName = "GreenLeader";
		ItemDescription = "A Green Minion Leader";
		ItemID = Random.Range (1, 101);

		MinionClassName = "Leader";
		MinionClassDescription = "Minion leaders are quite smart compared to other minion and can understand proper orders";
		
		Endurance = 8;
		Smarts = 11;
		Power = 9;
		Speed = 6;
		
		Size = 1;
	}	
}
