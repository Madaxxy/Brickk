﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public AudioClip hitSound;
    public Vector2 startVector;


    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(startVector, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(hitSound, new Vector3(0,0,0));
    }




}


	

