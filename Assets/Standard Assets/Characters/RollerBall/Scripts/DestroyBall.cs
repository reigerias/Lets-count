using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Simple Destroy Script, where the ball is hidden instead of being disabled
public class DestroyBall : MonoBehaviour {
   public static float DestroyTime;
    public static int ballDestroyed;
    void Start()
    {
        DestroyTime = 5f;
        ballDestroyed = 0;
    }  
    	void OnEnable()
    {
        Invoke("Destroy", DestroyTime);       
    }
    public void Destroy()
    {
        gameObject.SetActive(false);
        ballDestroyed++;
    }
    void OnDisable()
    {
        CancelInvoke();
    }
}
