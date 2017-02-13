using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouch : MonoBehaviour {
    public static bool touched = InputManager.ballHit;
    // Use this for initialization
    public Animator ani;
    void Start()
    {
        ani.enabled = false;
    }

    // Update is called once per frame
    void Update () {

        if (touched == true)
        {
            ani.enabled = true;
        }
        else
            ani.enabled = false; 
            
    }
}
