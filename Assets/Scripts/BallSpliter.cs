using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpliter : MonoBehaviour {
    private static int hitCheck; //interger to store score;
    private int score;
	// Use this for initialization
	void Start () {
        
        score = 0;
	}
	
	// Update is called once per frame
	void Update() {
        hitCheck = InputManager.score;
        if (hitCheck - score == 1)//checking if ball is hit or not!
        {
            BallCreator2.ballCounts+=2;
            CountDowntimer.timeStart += 1;
            score = hitCheck;
        }
       
	}
}
