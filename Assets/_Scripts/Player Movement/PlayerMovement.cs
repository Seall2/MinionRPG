using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10f;
	public float rotate = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("w")) 
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		if(Input.GetKey("s"))
		{
			transform.Translate(Vector3.back * speed * Time.deltaTime);
		}
		if(Input.GetKey("a"))
		{
			transform.Rotate(Vector3.down * rotate);
		}
		if(Input.GetKey("d"))
		{
			transform.Rotate(Vector3.up * rotate);
		}
	}
}
