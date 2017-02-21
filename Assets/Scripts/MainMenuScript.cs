using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class MainMenuScript : MonoBehaviour {

    // Use this for initialization
    public Button startText;
    public Button marketText;
    public Button leaderboard;
    private bool IsConnectedToGoogleServices;
   // public string leaderboard1;

    void Start () {
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.DebugLogEnabled = true;
        IsConnectedToGoogleServices = false;
       startText = startText.GetComponent<Button>();
        marketText = marketText.GetComponent<Button>();
        leaderboard = leaderboard.GetComponent<Button>(); 
    }
	public bool ConnectedToGoogleServices()
    {
        if(!IsConnectedToGoogleServices)
        {
            Social.localUser.Authenticate((bool success) => { IsConnectedToGoogleServices = success; });
        }
        return IsConnectedToGoogleServices;
    }
	// Update is called once per frame
	public void StartLevel()
    {
        SceneManager.LoadScene("Scenes/level1");
    }
    public void StartLeve2()
    {
        SceneManager.LoadScene("Scenes/level2");
    }

   public void leaderBoard()
    {
        PlayGamesPlatform.Activate();
        ConnectedToGoogleServices();
        if (Social.localUser.authenticated)
        {
            Social.ShowLeaderboardUI();
        }
        
    }

}
