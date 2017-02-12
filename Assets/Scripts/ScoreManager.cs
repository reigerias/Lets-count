using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private static int score;
    public static int newScore;// The player's score.
    public static int hiscore;
    public Text missCount;
    int miss;
    Text text;                      // Reference to the Text component.

    float hittime = 0;
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
        
        //select highscore;
       if( PlayerPrefs.GetInt("HighScore") != null)
        {
            hiscore = PlayerPrefs.GetInt("HighScore");

        } 

      }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        score = InputManager.score ;
        hittime = (hittime + Time.deltaTime);
        miss =  DestroyBall.ballDestroyed;
        
        if(EndCriterion.isRunning)
        {
            score = score + (int)(hittime);
            newScore = score;
            if (score > hiscore )
            {
                hiscore = score;
                PlayerPrefs.SetInt("HighScore", hiscore);
            }

        }
            
        text.text = "Score: " + score;
        if (miss == 1)
            missCount.text = "You missed "+ miss.ToString() +" ball.";
        else
            missCount.text = "You missed " + miss.ToString() + " balls.";
    }
}
