using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private static int score;
    public static int newScore;// The player's score.
    public static int hiscore;
    public static int previousScore; //Variable to store current as previous score.
    public Text missCount;
    private int level1score, level2score;
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
        if (Application.loadedLevelName == "level1")
        {
            if (PlayerPrefs.GetInt("HighScore1") != null)
            {
                level1score = PlayerPrefs.GetInt("HighScore1");
                hiscore = level1score;
            }
            if (PlayerPrefs.GetInt("prevScore1") != null)
            {
                previousScore = PlayerPrefs.GetInt("prevScore1");
            }
            else
                previousScore = 0;
        }
        else if (Application.loadedLevelName == "level2")
        {
            if (PlayerPrefs.GetInt("HighScore2") != null)
            {
                level2score = PlayerPrefs.GetInt("HighScore2");
                hiscore = level2score;
            }
            if (PlayerPrefs.GetInt("prevScore2") != null)
            {
                previousScore = PlayerPrefs.GetInt("prevScore2");
            }
            else
                previousScore = 0;
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
            if (Application.loadedLevelName == "level1")
            {
          
                if (score > level1score)
                {
                    level1score = score;
                    PlayerPrefs.SetInt("HighScore1", level1score);
                    hiscore = level1score;
                 }
                PlayerPrefs.SetInt("prevScore1", newScore);
             }
            else if (Application.loadedLevelName == "level2")
            {
                
                if (score > level2score)
                {
                    level2score = score;                   
                    PlayerPrefs.SetInt("HighScore2", level2score);
                    hiscore = level2score;
                }
                PlayerPrefs.SetInt("prevScore2", newScore);
            }
            

        }
            
        text.text = "Score: " + score;
        if(Application.loadedLevelName == "level1")
        {
            if (miss == 1)
                missCount.text = "You missed " + miss.ToString() + " ball.";
            else
                missCount.text = "You missed " + miss.ToString() + " balls.";
        }
       
    }
}
