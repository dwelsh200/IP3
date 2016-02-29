using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public int score;
	public int money = 500;
	public int energy;
	public int pollution;


	private Text text;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "Money: " + money + "\nSpawned: " + score;
	}

	public void addScore()
	{
		score++;
	}

	public void removeScore()
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
}
