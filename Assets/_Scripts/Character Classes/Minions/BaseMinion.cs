using UnityEngine;
using System.Collections;

public class BaseMinion 
{
	private string minionName;
	private int minionLevel;
	private BaseMinionClass minionClass;

	private int endurance;
	private int smarts;
	private int power;
	private int speed;
	
	public string MinionName
	{
		get{return minionName;}
		set{ minionName = value;}
	}
	
	public int MinionLevel
	{
		get{return minionLevel;}
		set{ minionLevel = value;}
	}
	
	public BaseMinionClass MinionClass
	{
		get{return minionClass;}
		set{ minionClass = value;}
	}
	
	public int Endurance
	{
		get{return endurance;}
		set{ endurance = value;}
	}
	
	public int Smarts
	{
		get{return smarts;}
		set{ smarts = value;}
	}
	
	public int Power
	{
		get{return power;}
		set{ power = value;}
	}
	
	public int Speed
	{
		get{return speed;}
		set{ speed = value;}
	}
}
