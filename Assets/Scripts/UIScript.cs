using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public int score;
	public double money = 500f;
	public double population;
	public int tourism;
	public double pollution;
	public int happiness;
	public int energy;

    private Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{     
		text.text = "Spawned: " + score + "\nMoney: " + money + "\nPollution: " + pollution + "\nPopulation: " + population + "\nHappiness: " + happiness + "\nEnergy: " + energy + "\nTourism: " + tourism;
    }

    public void addSpawnedScore()
	{
		score++;
	}

	public void removeSpawnedScore()
	{
		score--;
	}

	public void removeMoney(int amount)
	{
		money -= amount;
	}

	public void addMoney(int amount)
	{
		money += amount;
	}

    public void addPollution(int amount)
    {
		pollution += amount;
    }

	public void removePollution(int amount)
	{
		pollution -= amount;
	}

	public void addPopulation(int amount)
	{
		population += amount;
	}

	public void removePopulation(int amount)
	{
		population -= amount;
	}

	public void addTourism(int amount)
	{
		tourism += amount;
	}

	public void removeTourism(int amount)
	{
		tourism -= amount;
	}

	public void addHappiness(int amount)
	{
		happiness += amount;
	}

	public void removeHappiness(int amount)
	{
		happiness -= amount;
	}

	public void addEnergy(int amount)
	{
		energy += amount;
	}

	public void removeEnergy(int amount)
	{
		energy -= amount;
	}
}
