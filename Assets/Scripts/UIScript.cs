using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public int score;
	public int money = 500;
	public int energy;
	public double pollutionRate;
    public double currentPollution;

    private float timeRate = 10f;
    private float nextTime = 0;


    private Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        
        text.text = "Money: " + money + "\nSpawned: " + score + "\nPollution:" + currentPollution;

        if (Time.time > nextTime)
        {
         nextTime = Time.time + timeRate;
         currentPollution = currentPollution * pollutionRate * 1.09 * ( energy  *0.5);
        }

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
        pollutionRate = pollutionRate * 1.01 * (amount*0.5);
     }
}
