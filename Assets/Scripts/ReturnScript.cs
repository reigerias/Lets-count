using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnScript : MonoBehaviour {

    // Use this for initialization
    public Button startText;

    void Start()
    {
        startText = startText.GetComponent<Button>();

    }

    // Update is called once per frame
    public void StartMen()
    {
        Application.LoadLevel("Menu");
    }
}
