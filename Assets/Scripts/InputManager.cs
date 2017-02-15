using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    // Use this for initialization
    public static int score;
     
        //Some shit code from net to handle fucking inputs!
    public static bool ballHit;//Checks whether ball is hit or not!
    void Start()
    {
        ballHit = false;
    }
    void Update () {
        if ( EndCriterion.isRunning == true) {
            if (Input.GetMouseButtonDown(0))
            {
                {
                    
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {

                        if (hit.collider.gameObject.tag == "Retro")
                        {
                            hit.collider.gameObject.SetActive(false);
                            Debug.Log("It was hit!!!");
                            ballHit = true;
                                score++;
                            Debug.Log("Score = " + score);
                            //  GetBallNumber += 1;

                        }
                        else
                        {
                            CountDowntimer.timeStart-=2f;

                        }
                    }
                }
            }

            int nbTouches = Input.touchCount;

            if (nbTouches > 0)
            {
                for (int i = 0; i < nbTouches; i++)
                {
                    Touch touch = Input.GetTouch(i);

                    if (touch.phase == TouchPhase.Began)
                    {
                      
                        Ray screenRay = Camera.main.ScreenPointToRay(touch.position);

                        RaycastHit hit;
                        if (Physics.Raycast(screenRay, out hit))
                        {
                            if (hit.collider.gameObject.tag == "Retro")
                            {
                                hit.collider.gameObject.SetActive(false);
                                Debug.Log("It was hit!!!");
                                ballHit = true;
                                score++;
                                Debug.Log("Score = " + score);
                                //  GetBallNumber += 1;

                            }
                        }
                    }

                }
            }

          }
        else if (EndCriterion.isRunning == false)
        {
            score = 0; 
        }
		
    }
}
