using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndCriterion : MonoBehaviour {

    // Use this for initialization
    private static int BallCount;
   private static int UpdateMiss;
    public static bool isRunning;
    int missed;
	void Start () {
        BallCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMiss = CameraMovement.misscount;
        IsRunning();
        BallCount = DestroyBall.ballDestroyed;
        missed = BallCount;
        if (Application.loadedLevelName == "level1")
        {
            if (missed >= UpdateMiss)
            {
                Debug.Log("GAME OVER! GG NOOB!");
                SceneManager.LoadScene("Scenes/Hi-Score");
                isRunning = false;
            }
        }

        else if (Application.loadedLevelName == "level2")
        {

            if (CountDowntimer.timeStart <= 0)
            {
                Debug.Log("GAME OVER! GG NOOB!");
                SceneManager.LoadScene("Scenes/Hi-Score");
                isRunning = false;
            }
        }
    }

    public void IsRunning()
    {
        isRunning = true;
    }
   
}
