using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class ScoreDisplayer : MonoBehaviour {
    public Text scoreText;
    public Text hiscoreText;
    float t;
    int score, hiscore;
	// Use this for initialization
	void Start () {
        score = ScoreManager.newScore;
        hiscore = ScoreManager.hiscore;
        t = t + Time.deltaTime;
        scoreText.text = score.ToString();
        hiscoreText.text = hiscore.ToString();
        StartCoroutine(WaitAndLoadScene());
        ScoreManager.SaveToLeaderboard();
    }

    IEnumerator WaitAndLoadScene()
    {
        
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Scenes/Menu");
      
    }
    // Update is called once per frame
    
}
