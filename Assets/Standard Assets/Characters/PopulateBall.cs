using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateBall : MonoBehaviour
{

    // Use this for initialization
    public GameObject ball; // A gameobject to hold ball prefab!
    GameObject balls;
    public static int score;
    public static float BallTimer; //Rate at which ball is being spawned. Initail BallTimer = 2f; 
    float RepeaterTime = 1f; // Time to repeat the ball spawn
    public static float DestroyTime; //Destroy period of ball
    public static float UpdateTime; 
    void Start()
    {
        BallTimer = 2f;
        DestroyTime = 5f;
        Debug.Log("Hello I'm ball");
        InvokeRepeating("spawnball", BallTimer , RepeaterTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroting ball on MouseClick.
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


                    }
                }
            }
        }
        Destroy(balls, 5f); //Default destroy time.
       // UpdateTime += Time.deltaTime;
        
     }
    void spawnball()
    {
        Vector3 position = new Vector3(UnityEngine.Random.Range(0, 4), UnityEngine.Random.Range(0, 4), UnityEngine.Random.Range(506, 506));
        balls = Instantiate(ball, position, Quaternion.identity) as GameObject;
        balls.gameObject.tag = "Retro";
        
            
    }
 }