using UnityEngine;
using System.Collections;

public class BaseMinionClass : BaseItem 
{
	private string minionClassName;
	private string minionClassDescription;

	//stats
	//Health
	private int endurance;
	//intelligent
	private int smarts;
	//strength/damage
	private int power;
	//Crits
	private int speed;

	//The amount of Minions this add to the group 
	private int size;

	public string MinionClassName
	{
		get{return minionClassName;}
		set{minionClassName = value;}
	}

	public string MinionClassDescription
	{
		get{return minionClassDescription;}
		set{minionClassDescription = value;}
	}

	public int Endurance
	{
		get{return endurance;}
		set{endurance = value;}
	}

	public int Smarts
	{
		get{return smarts;}
		set{smarts = value;}
	}

	public int Power
	{
		get{return power;}
		set{power = value;}
	}

	public int Speed
	{
		get{return speed;}
		set{speed = value;}
	}

	//The number of minions added to your group by this type.
	//min: 1
	//max: 4
	public int Size
	{
		get{return size;}
		set{size = value;}
	}
}
