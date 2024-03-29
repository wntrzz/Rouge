﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

  public static GameManager instance = null;
  public BoardManager boardScript;
  public int playerFoodPoints = 100;
  [HideInInspector] public bool playersTurn = true;

  private int level = 3;

	// Use this for initialization
	void Awake () {
	  if (instance == null) {
	    instance = this;
	  } else if (instance != null) {
	    Destroy(gameObject);
	  }

    DontDestroyOnLoad(gameObject);
	  boardScript = GetComponent<BoardManager>();
	  InitGame();
	}

  void InitGame() {
    boardScript.SetupScene(level);
  }

  public void GameOver() {
    enabled = false;
  }
	
	// Update is called once per frame
	void Update () {
		
	}
}
