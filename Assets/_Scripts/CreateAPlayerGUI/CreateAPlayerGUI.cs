using UnityEngine;
using System.Collections;

public class CreateAPlayerGUI : MonoBehaviour 
{
	public enum CreateAPlayerStates
	{
		CLASSSELECTION,
		FINALSETUP
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions(); 
	public static CreateAPlayerStates currentstate;

	// Use this for initialization
	void Start () 
	{
		currentstate = CreateAPlayerStates.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch (currentstate) 
		{
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		}
	}

	void OnGUI()
	{
		displayFunctions.DisplayMainItems ();

		if (currentstate == CreateAPlayerStates.CLASSSELECTION) 
		{
			displayFunctions.DisplayClassSelections();
		}

		if (currentstate == CreateAPlayerStates.FINALSETUP) 
		{
			displayFunctions.DisplayChoice();
			displayFunctions.DisplayFinalSetup();
		}
	}
}
