using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Use this for initialization
    private static int score;
    int UpdateScore;
    int LastScore; 
    float UpdateTime;
    float LastTime; 
    int moveCamera;
    
	void Start () {
        score = PopulateBall.score;
        UpdateScore = 0;
        LastScore = 0; 
        UpdateTime = 0;
        moveCamera = 0; 

    }

    // Update is called once per frame
    void Update() {
        score = PopulateBall.score;
        UpdateScore = score - LastScore;
        Debug.Log("Checking score" + UpdateScore); 
        UpdateTime = (UpdateTime + Time.deltaTime); 
        if (UpdateScore >= 10) 
        {
            moveCamera = -1;
            transform.Translate(0, 0, moveCamera);
            ResetScore();
        }
        if (UpdateTime > 20) {
            moveCamera = -1;
            transform.Translate(0, 0, moveCamera);
            ResetTime();
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
}

