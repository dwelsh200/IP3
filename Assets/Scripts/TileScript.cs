using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

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
		//BoardScript bs = GameObject.Find("GameData").GetComponent<BoardScript>();
		//bs.changeTile(transform.position[0], transform.position[2]);
		//bs.spawnOnTile(transform.position[0], transform.position[2]);
		if(bs.isUIActive)
		{
			bs.buildUIOff();
		}
		else
		{
			//activate canvas
			bs.setActiveTile(transform.position[0], transform.position[2]);
			bs.buildUIOn();
			//move button to tile
			//pass tile x & z to boardscript to indicate active tile
		}
	}
}
