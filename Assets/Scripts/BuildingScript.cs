using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	//variables for individual building stats
	public int money;
	public int population;
	public int tourism;
	public int pollution;
	public int happiness;
	public int energy;

	private BoardScript bs;

	// Use this for initialization
	void Start () 
	{
		bs = GameObject.Find("GameData").GetComponent<BoardScript>();
		bs.UI.removeMoney(money);
		bs.UI.addPopulation(population);
		bs.UI.addTourism(tourism);
		bs.UI.addPollution(pollution);
		bs.UI.addHappiness(happiness);
		bs.UI.addEnergy(energy);
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
