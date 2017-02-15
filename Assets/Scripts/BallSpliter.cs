using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpliter : MonoBehaviour {
    private static int hitCheck; //interger to store score;
    private int score, score1;
    private float AddTimer;
    private int UpdateScore;
	// Use this for initialization
	void Start () {
        
        score = 0;
        score1 = 0;
        UpdateScore =10 ;
     
	}
	
	// Update is called once per frame
	void Update() {
        hitCheck = InputManager.score;
        if (hitCheck - score == 1)//checking if ball is hit or not!
        {
            
            BallCreator2.ballCounts+=1;
           
            score = hitCheck;
        }
        if (hitCheck - score1 == UpdateScore)
        {
            UpdateScore += (5);
            CountDowntimer.timeStart += 5f;
            score1 = hitCheck;
        }

    }
    
}
