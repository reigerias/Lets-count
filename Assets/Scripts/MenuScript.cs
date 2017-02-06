using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    // Use this for initialization
    public Button startText;
    
	void Start () {
        startText = startText.GetComponent<Button>();
       
    }
	
	// Update is called once per frame
	public void StartLevel()
    {
        Application.LoadLevel("Menu");
    }

  }
