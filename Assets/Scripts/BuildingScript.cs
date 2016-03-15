using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

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
		if(!EventSystem.current.IsPointerOverGameObject())
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
}
