using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public int score;
	Text text;
    
	// Use this for initialization
	void Start () 
	{
	    text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "Spawned: " + score;

	}

	public void addScore()
	{
		score++;
	}

}
