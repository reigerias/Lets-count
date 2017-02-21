using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Use this for initialization
    private static int score;
    int UpdateScore , Update100Score , Last100Score;
    static int LastScore; 
    float UpdateTime;
    float LastTime;
    public static int misscount;
    int newUpdateScore;
    
	void Start () {
        score = InputManager.score;
        UpdateScore = 0;
        Update100Score = Last100Score = 0;
       LastScore = 0; 
        UpdateTime = 0;
        misscount = 3;
        newUpdateScore = 20; 
               
    }

    // Update is called once per frame You can figure this out ! its easy man!
    void Update() {
        score = InputManager.score; // Get the score from input!
        UpdateScore = score - LastScore;
        Update100Score = score - Last100Score; // Check if the difference of score is 10 
        Debug.Log("Checking score" + UpdateScore); 
        UpdateTime = (UpdateTime + Time.deltaTime); //Check time!!
        if (Update100Score >= 100)
        {
            Reset100Score();
            if (misscount == 8)
                misscount = 8;
            else
                misscount++;
            UpdateDestroyTime();
        }
        if (UpdateScore >= newUpdateScore || UpdateTime > 20)
        {
            //moveCamera = -1f;
            Camera.main.orthographicSize += 0.5f ;
            newUpdateScore += 10;
             if (UpdateScore >= 20)
            {
                ResetScore();
                if (CreatingBall.ballCount == 16)
                    CreatingBall.ballCount = 16;
                else
                    CreatingBall.ballCount += 1;
            }
                 //Increasing the ball count! If you remember!! XD       
           
            if (UpdateTime > 20)
            {
                ResetTime();                
            }
            UpdateBallTimer();
                  
          }       
    }
    public void ResetScore()
        {
        LastScore += UpdateScore;
        UpdateScore = 0;
        }
    public void Reset100Score()
    {
        Last100Score += Update100Score;
        UpdateScore = 0;
    }
    public void ResetTime()
    {
       UpdateTime = 0;

    }

    public void UpdateBallTimer()
    {
        if (CreatingBall.BallTimer == 0.365f)
            CreatingBall.BallTimer = 0.365f;
        else
           CreatingBall.BallTimer -= 0.2f;
    }
    public void UpdateDestroyTime()
    {
        if (DestroyBall.DestroyTime == 12f)
            DestroyBall.DestroyTime = 12f;
        else
            DestroyBall.DestroyTime += 2f;
    }
    public static int getScore() {
        return LastScore;
    }
}

