﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameManager theGameManager;
    // Use this for initialization
    void Start()
    {
        theGameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Game Over");
        theGameManager.LoadLevel("GameOver");
    }
    // Update is called once per frame
}
