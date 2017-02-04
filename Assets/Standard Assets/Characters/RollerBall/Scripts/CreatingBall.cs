using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingBall : MonoBehaviour {
    public GameObject ball; // This is a gameObject

    public static float BallTimer; //Timer for Ball to spawn
    public static int RandomLocation; // Defines the matrix number initially 4x4 board!
     int pooledAmount ; // Max number of ball to be initialized
    public static int ballCount; // No of balls to be appeared!
    List<GameObject> balls; // List of balls
     void Start()
    {
        RandomLocation = 4;
        BallTimer = 2f; 
        balls = new List<GameObject>(); 
        pooledAmount = 20;
       //Adding the object to list
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(ball);
            obj.SetActive(false);
            balls.Add(obj);
           
         }
        ballCount = 1;
        InvokeRepeating("SpawnBall", BallTimer , 1f ); //Spawning ball
    }
    void SpawnBall()
    {
        //Enables the Ball according to the Ball count!!
        for ( int i = 0; i < ballCount; i++  )
        {
            if(!balls[i].activeInHierarchy)
            {
                Vector3 position = new Vector3(UnityEngine.Random.Range(0, RandomLocation), UnityEngine.Random.Range(0, RandomLocation), UnityEngine.Random.Range(506, 506));//Defining random position
                balls[i].transform.position = position;
                balls[i].transform.rotation = Quaternion.identity;
                balls[i].SetActive(true); // Enabling the ball
            }
        }
    }
}
