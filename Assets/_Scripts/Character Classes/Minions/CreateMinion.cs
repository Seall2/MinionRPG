using UnityEngine;
using System.Collections;

public class CreateMinion
{
	private BaseMinion newMinion;
	private bool isSwarmClass;
	private bool isBruteClass;
	private bool isLeaderClass;
	private bool isBufferClass;
	private string minionName = "";
	private BaseMinionClass[] minionTypes = new BaseMinionClass[]{new BaseMinionSwarm(), new BaseMinionBrute(), new BaseMinionLeader(), new BaseMinionBuffer()};
	private BaseMinionClass minion;

	// Use this for initialization
	void Start () 
	{
		newMinion = new BaseMinion();

		minion = minionTypes [Random.Range (0, minionTypes.Length + 1)];
		
		if (minion.MinionClassName == "Swarm") 
		{
			isSwarmClass = true;
		} 
		else if (minion.MinionClassName == "Brute") 
		{
			isBruteClass = true;
		}
		else if (minion.MinionClassName == "Leader") 
		{
			isLeaderClass = true;
		}
		else if (minion.MinionClassName == "Buffer") 
		{
			isBufferClass = true;
		}
		
		minionName = newMinion.MinionClass.MinionClassName;
		
		if(isSwarmClass)
		{
			newMinion.MinionClass = new BaseMinionSwarm();
		}
		else if(isBruteClass)
		{
			newMinion.MinionClass = new BaseMinionBrute();
		}
		else if(isLeaderClass)
		{
			newMinion.MinionClass = new BaseMinionLeader();
		}
		else if(isBufferClass)
		{
			newMinion.MinionClass = new BaseMinionBuffer();
		}
		
		newMinion.MinionLevel = 1;
		newMinion.Endurance = newMinion.MinionClass.Endurance;
		newMinion.Smarts = newMinion.MinionClass.Smarts;
		newMinion.Power = newMinion.MinionClass.Power;
		newMinion.Speed = newMinion.MinionClass.Speed;
		newMinion.MinionName = minionName;
		
		StoreNewPlayerInfo();
		SaveInformation.SaveAllInformation();
	}

	public void CreateyourMinion()
	{
				newMinion = new BaseMinion();

		minion = minionTypes [Random.Range (0, minionTypes.Length + 1)];
		
		if (minion.MinionClassName == "Swarm") 
		{
			isSwarmClass = true;
		} 
		else if (minion.MinionClassName == "Brute") 
		{
			isBruteClass = true;
		}
		else if (minion.MinionClassName == "Leader") 
		{
			isLeaderClass = true;
		}
		else if (minion.MinionClassName == "Buffer") 
		{
			isBufferClass = true;
		}
		
		minionName = newMinion.MinionClass.MinionClassName;
		
		if(isSwarmClass)
		{
			newMinion.MinionClass = new BaseMinionSwarm();
		}
		else if(isBruteClass)
		{
			newMinion.MinionClass = new BaseMinionBrute();
		}
		else if(isLeaderClass)
		{
			newMinion.MinionClass = new BaseMinionLeader();
		}
		else if(isBufferClass)
		{
			newMinion.MinionClass = new BaseMinionBuffer();
		}
		
		newMinion.MinionLevel = 1;
		newMinion.Endurance = newMinion.MinionClass.Endurance;
		newMinion.Smarts = newMinion.MinionClass.Smarts;
		newMinion.Power = newMinion.MinionClass.Power;
		newMinion.Speed = newMinion.MinionClass.Speed;
		newMinion.MinionName = minionName;
		
		StoreNewPlayerInfo();
		SaveInformation.SaveAllInformation();
	}

	private void StoreNewPlayerInfo()
	{
		GameInformations.MinionName = newMinion.MinionName;
		GameInformations.MinionLevel = newMinion.MinionLevel;
		GameInformations.Endurance = newMinion.Endurance;
		GameInformations.Smarts = newMinion.Smarts;
		GameInformations.Power = newMinion.Power;
		GameInformations.Speed = newMinion.Speed;
	}
}
