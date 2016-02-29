using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	private BoardScript bs;

	// Use this for initialization
	void Start () 
	{
		bs = GameObject.Find("GameData").GetComponent<BoardScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseDown()
	{		
		if(bs.isUIActive)
		{
			//activate tile
			bs.setActiveTile(transform.position[0], transform.position[2]);
		}
		else
		{
			//activate tile
			//activate canvas
			bs.setActiveTile(transform.position[0], transform.position[2]);
			bs.buildUIOn();
		}
	}
}
