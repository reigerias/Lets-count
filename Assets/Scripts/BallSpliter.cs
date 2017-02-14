using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpliter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("OnBallHit", 0.1f, 1f);
	}
	
	// Update is called once per frame
	void OnBallHit( ) {
		if (InputManager.ballHit ==true)
        {
            BallCreator2.ballCounts++;
            CountDowntimer.timeStart += 1;
        }
	}
}
