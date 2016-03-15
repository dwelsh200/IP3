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
	public int buildingID;

	//variables for incremental building stats
	public int pollutionIncrement;
	public int populationIncrement;
	public int moneyIncrement;

	public float timeRate = 10f;
    public float nextTime = 0;

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
		if (Time.time > nextTime)
        {
         	nextTime = Time.time + timeRate;       
			switch(buildingID)
			{
				case 0:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
				case 1:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
				case 2:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
				case 3:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
				case 4:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
				case 5:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
				case 6:
					bs.UI.addPopulation(populationIncrement);
					bs.UI.addPollution(pollutionIncrement);
					bs.UI.addMoney(moneyIncrement);
					break;
			}
		}
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
