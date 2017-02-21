using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour {
    public float moveSpeed;
    private float playerRadius;
    private float minX, maxX, minY, maxY;
    private float  tChange = 0; // force new direction in the first Update
    private float randomX, randomY;
    void Start()
    {
        moveSpeed =2.5f;
       float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        //in Start
        SphereCollider playerCollider = GetComponent<SphereCollider>();
        playerRadius = playerCollider.bounds.extents.x;

        tChange = 0;
                
        minX = bottomCorner.x + playerRadius;
        maxX = topCorner.x - playerRadius;
        minY = bottomCorner.y + playerRadius;
        maxY = topCorner.y - playerRadius;


    }
    void Update()
    {
        if (Time.time >= tChange)
        {
            randomX = UnityEngine.Random.Range(-2.0f, 2.0f); // with float parameters, a random float
            randomY = UnityEngine.Random.Range(-2.0f, 2.0f); //  between -2.0 and 2.0 is returned
                                               // set a random interval between 0.5 and 1.5
            tChange = Time.time + UnityEngine.Random.Range(0.5f, 1.5f);
        }
        transform.Translate(new Vector3(randomX, randomY, 485 )* moveSpeed * Time.deltaTime);
        // if object reached any border, revert the appropriate direction
        if (transform.position.x >= maxX || transform.position.x <= minX)
        {
            randomX = -randomX;
        }
        if (transform.position.y >= maxY || transform.position.y <= minY)
        {
            randomY = -randomY;
        }
        // make sure the position is inside the borders
       float x = Mathf.Clamp(transform.position.x, minX, maxX);
       float y = Mathf.Clamp(transform.position.y, minY, maxY);
        transform.position = new Vector3(x, y, 485);

    }
}