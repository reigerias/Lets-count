using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {
    public Text timerText;
    private float startTime;
    float t;
    private static bool StopTime;
    // Use this for initialization
    void Start () {
        StopTime = (EndCriterion.isRunning);
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
       // if (!StopTime)
          //  return;
        t = Time.time - startTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");
        timerText.text = min + ":" + sec;        

	}
}
