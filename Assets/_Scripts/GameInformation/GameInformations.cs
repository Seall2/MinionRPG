using UnityEngine;
using System.Collections;

public class GameInformations : MonoBehaviour 
{
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	public static string PlayerName{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static BaseCharacterClass PlayerClass{ get; set; }
	public static int PartySize{ get; set; }
	public static int MinionNum{ get; set; }
	public static int HandSize{ get; set; }
	public static int DeckSize{ get; set; }

	public static string MinionName{ get; set; }
	public static int MinionLevel{ get; set; }
	public static BaseMinionClass MinionClass{ get; set; }
	public static int Endurance{ get; set; }
	public static int Smarts{ get; set; }
	public static int Power{ get; set; }
	public static int Speed{ get; set; }
}
