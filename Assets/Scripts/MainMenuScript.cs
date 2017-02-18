using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    // Use this for initialization
    public Button startText;
    public Button marketText;
	void Start () {
        startText = startText.GetComponent<Button>();
        marketText = startText.GetComponent<Button>();
    }
	
	// Update is called once per frame
	public void StartLevel()
    {
        SceneManager.LoadScene("Scenes/level1");
    }

    public void OpenMarket()
    {
        SceneManager.LoadScene("Scenes/level2");
    }
}
