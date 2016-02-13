using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		//Destroy(this.gameObject);
		BoardScript bs = GameObject.Find("GameData").GetComponent<BoardScript>();
		//bs.changeTile(transform.position[0], transform.position[2]);
		bs.spawnOnTile(transform.position[0], transform.position[2]);
	}
}
