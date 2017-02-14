﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator2 : MonoBehaviour
{
    public GameObject ball; // This is a gameObject
    public static int x;
    public static float BallTimer; //Timer for Ball to spawn
    public static int RandomLocation; // Defines the matrix number initially 4x4 board!
    public int pooledAmount; // Max number of ball to be initialized
    private int ballCount; // No of balls to be appeared!
    private bool CheckHit; // Checks ball hit to split it!
    List<GameObject> balls; // List of balls
    void Start()
    {
        RandomLocation = 4;
        BallTimer = 0.36f;
        balls = new List<GameObject>();
        pooledAmount = 20;
        //Adding the object to list
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(ball);
            obj.SetActive(false);
            balls.Add(obj);

        }
        ballCount = 1;

        InvokeRepeating("SpawnBall", BallTimer, BallTimer);
    }
    void SpawnBall()
    {
        //Enables the Ball according to the Ball count!!

        for (int i = 0; i < ballCount; i++)
        {
            
                if (!balls[i].activeInHierarchy)
                {
                    Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width - 100), Random.Range(0, Screen.height - 100), Camera.main.farClipPlane / 2));
                    balls[i].transform.position = position;
                    balls[i].transform.rotation = Quaternion.identity;
                    balls[i].SetActive(true); // Enabling the ball
                }
            }
        }
    }