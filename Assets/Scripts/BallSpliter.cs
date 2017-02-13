using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpliter : MonoBehaviour {
    private bool CheckHit; // Checks ball hit to split it!
	// Use this for initialization
	void Start () {
        CheckHit = InputManager.ballHit;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
