using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        Application.LoadLevel("level1");
    }

    public void OpenMarket()
    {
        Application.LoadLevel("Market");
    }
}
