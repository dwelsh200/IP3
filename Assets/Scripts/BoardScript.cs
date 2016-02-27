using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardScript : MonoBehaviour 
{
	//Variables for the board's different tile types
	public List<GameObject> tiles;
	public List<GameObject> objects;

	//Board settings, open in editor for designers
	public int setGridWidth;
	public int setGridHeight;
	public static int gridWidth;
	public static int gridHeight;
	public float tileSize = 1;

	//Boards, one with numbers representing what's in the tile and one with the instantiated tiles inside and one for objects spawned on top of tiles
	private int[,] board;
	private GameObject[,] boardTiles;
	private GameObject[,] boardObjects;

	//Position of object being instantiated
	private Vector3 position;

	UIScript UI;

	// Use this for initialization
	void Start () 
	{
		UI = GameObject.Find("Text").GetComponent<UIScript>(); 
		gridWidth = setGridWidth;
		gridHeight = setGridHeight;
		board = new int[gridWidth, gridHeight];
		boardTiles = new GameObject[gridWidth, gridHeight];
		boardObjects = new GameObject[gridWidth, gridHeight];
		for (int i = 0; i < gridWidth; i++)
		{
			for(int j = 0; j < gridHeight; j++)
			{
				position = new Vector3(i * tileSize, 0.0f, j * tileSize);
				boardTiles[i, j] = Instantiate(tiles[0], position, Quaternion.identity) as GameObject;
				board[i, j] = 0;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}

	//Used to convert an object's position to an index in our grid
	public int convertFloatToInt(float fNumber)
	{
		fNumber /= tileSize;        
		int iNumber = Mathf.RoundToInt(fNumber);
		return iNumber;
	}

	//Deletes old tile and replaces it with a new one
	public void changeTile(float xF, float zF)
	{
		int x = convertFloatToInt(xF);
		int z = convertFloatToInt(zF);
		Destroy(boardTiles[x, z]);
		board[x, z] = 1;
		position = new Vector3(x * tileSize, 0.0f, z * tileSize);
		boardTiles[x, z] = Instantiate(tiles[1], position, Quaternion.identity) as GameObject;
	}

	public void spawnOnTile(float xF, float zF)
	{
		int x = convertFloatToInt(xF);
		int z = convertFloatToInt(zF);
		if(board[x, z] == 0)
		{
			Destroy(boardObjects[x, z]);
			board[x, z] = 2;
			position = new Vector3(x * tileSize, 0.0f, z * tileSize);
			boardTiles[x, z] = Instantiate(objects[0], position, Quaternion.identity) as GameObject;
			UI.addScore();
		}
	}
}
