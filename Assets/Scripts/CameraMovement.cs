using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Use this for initialization
    private static int score;
    int UpdateScore;
    static int LastScore; 
    float UpdateTime;
    float LastTime; 
    float moveCamera;
    
	void Start () {
        score = InputManager.score;
        UpdateScore = 0;
        LastScore = 0; 
        UpdateTime = 0;
        moveCamera = 0; 

    }

    // Update is called once per frame You can figure this out ! its easy man!
    void Update() {
        score = InputManager.score; // Get the score from input!
        UpdateScore = score - LastScore; // Check if the difference of score is 10 
        Debug.Log("Checking score" + UpdateScore); 
        UpdateTime = (UpdateTime + Time.deltaTime); //Check time!!
        if (UpdateScore >=10 || UpdateTime > 20)
        {
            moveCamera = -1f;
            transform.Translate(0, 0, moveCamera);
            if (UpdateScore >= 10)
            {                
                ResetScore();
                CreatingBall.ballCount += 1;       //Increasing the ball count! If you remember!! XD       
            }
            if (UpdateTime > 20)
            {
                ResetTime();                
            }
            CreatingBall.RandomLocation += 1;
            UpdateBallTimer();
            UpdateDestroyTime();            
          }       
    }
    public void ResetScore()
        {
        LastScore += UpdateScore;
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
            DestroyBall.DestroyTime += 0.2f;
    }
    public static int getScore() {
        return LastScore;
    }
}

