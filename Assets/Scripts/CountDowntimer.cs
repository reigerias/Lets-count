using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountDowntimer : MonoBehaviour {
    public Text timerText;
    public static float timeStart;
    
    // Use this for initialization
    void Start () {
        
        timeStart =10f; 
    }
	
	// Update is called once per frame
	void Update () {
       // if (!StopTime)
          //  return;
        timeStart -= Time.deltaTime;
        string min = ((int)timeStart / 60).ToString();
        string sec = (timeStart % 60).ToString("f2");
        timerText.text = min + ":" + sec;        

	}
   
}
