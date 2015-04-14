using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseMinionBrute : BaseMinionClass
{
	public BaseMinionBrute()
	{
		ItemName = "GreenBrute";
		ItemDescription = "A Green Minion Brute";
		ItemID = Random.Range (1, 101);

		MinionClassName = "Brute";
		MinionClassDescription = "Brutes have alot of power and ...well they have power";

		Endurance = 10;
		Smarts = 1;
		Power = 13;
		Speed = 4;

		Size = 2;
	}
}
