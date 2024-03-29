﻿using UnityEngine;
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

	//Coordinates of the selected tile
	private int activeX;
	private int activeZ;
	private int oldActiveX;
	private int oldActiveZ;

	UIScript UI;

	//Testing the building UI
	public GameObject buildingUI;
	public bool isUIActive = false;

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
	public void changeTile(float xF, float zF, int tile)
	{
		int x = convertFloatToInt(xF);
		int z = convertFloatToInt(zF);
		Destroy(boardTiles[x, z]);
		//board[x, z] = 1;
		position = new Vector3(x * tileSize, 0.0f, z * tileSize);
		boardTiles[x, z] = Instantiate(tiles[tile], position, Quaternion.identity) as GameObject;
	}

	public void changeTile(int x, int z, int tile)
	{
		Destroy(boardTiles[x, z]);
		//board[x, z] = 1;
		position = new Vector3(x * tileSize, 0.0f, z * tileSize);
		boardTiles[x, z] = Instantiate(tiles[tile], position, Quaternion.identity) as GameObject;
	}

	public void spawnOnTile(float xF, float zF)
	{
		int x = convertFloatToInt(xF);
		int z = convertFloatToInt(zF);
		if(board[x, z] == 0 && UI.money >= 100)
		{
			Destroy(boardObjects[x, z]);
			board[x, z] = 2;
			position = new Vector3(x * tileSize, 0.0f, z * tileSize);
			boardObjects[x, z] = Instantiate(objects[0], position, Quaternion.identity) as GameObject;
			UI.addScore();
			UI.removeMoney(100);
		}
	}

	public void spawnOnActiveTile(int building)
	{
		if(board[activeX, activeZ] == 0 && UI.money >= 100)
		{
			Destroy(boardObjects[activeX, activeZ]);
			board[activeX, activeZ] = 2;
			position = new Vector3(activeX * tileSize, 0.0f, activeZ * tileSize);
			boardObjects[activeX, activeZ] = Instantiate(objects[building], position, Quaternion.identity) as GameObject;
			UI.addScore();
			UI.removeMoney(100);
		}
	}

	public void destroyOnActiveTile()
	{
		if(board[activeX, activeZ] != 0)
		{
			Destroy(boardObjects[activeX, activeZ]);
			board[activeX, activeZ] = 0;
			UI.removeScore();
			UI.addMoney(50);
		}
	}

	public void setActiveTile(float xF, float zF)
	{
		int x = convertFloatToInt(xF);
		int z = convertFloatToInt(zF);
		oldActiveX = activeX;
		oldActiveZ = activeZ;
		activeX = x;
		activeZ = z;
		changeTile(xF, zF, 1); //new tile
		changeTile(oldActiveX, oldActiveZ, 0); //old tile
	}

	public void buildUIOn()
	{
		isUIActive = true;
		buildingUI.SetActive(true);

	}

	public void buildUIOff()
	{
		isUIActive = false;
		buildingUI.SetActive(false);
	}
}
