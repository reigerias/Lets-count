using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateBall : MonoBehaviour
{

    // Use this for initialization
    public GameObject ball; // A gameobject to hold ball prefab!
    GameObject balls;
    public static int score, Miss;
    public static float BallTimer; //Rate at which ball is being spawned. Initail BallTimer = 2f; 
    public static float DestroyTime; //Destroy period of ball
    public static int RandomLocation; // Position for random location
    public static int GetBallNumber;
     private float timestamp;
    void Start()
    {
        BallTimer = 2f;
        DestroyTime = 5f;
        Debug.Log("Hello I'm ball");
        RandomLocation = 4;
        GetBallNumber = 0; 
        //InvokeRepeating("spawnball", BallTimer , RepeaterTime);
        timestamp = Time.time + BallTimer;
              
    }

    // Update is called once per frame
    void Update()
    {
        
        if (EndCriterion.isRunning == true)
        {
            if (timestamp < Time.time)
            {
                spawnball();
                for (int i = 10; i <= CameraMovement.getScore() ; i = i + 10)// Increase ball number
                {
                    spawnball();
                }
                    timestamp += BallTimer;
            }

            getInput();
            Destroy(balls, DestroyTime);   
                   
           
        }
        else
        {
           Stop();
        }
            

        
     }
    void spawnball()
    {
        Vector3 position = new Vector3(UnityEngine.Random.Range(0, RandomLocation), UnityEngine.Random.Range(0, RandomLocation), UnityEngine.Random.Range(506, 506));
        balls = Instantiate(ball, position, Quaternion.identity) as GameObject;
         balls.gameObject.tag = "Retro";
        GetBalls();
     }
   public void Stop()
    {

        Debug.Log("Stop Called");      
        Destroy(balls);
        Destroy(ball);

    }
    public void GetBalls()
   {
               GetBallNumber += 1;
    }
    public void getInput() {
      //Destroting ball on MouseClick.
        {
            if (Input.GetMouseButtonDown(0))
            {
                {
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {

                        if (hit.collider.gameObject.tag == "Retro")
                        {
                            Destroy(hit.collider.gameObject);
                            Debug.Log("It was hit!!!");
                            score++;
                            Debug.Log("Score = " + score);
                            //  GetBallNumber += 1;

                        }
                    }
                }
            }
        }
    }
 }