using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	float limitXneg, limitYneg, limitXpos, limitYpos;
	// Use this for initialization
	void Start () {
		limitXneg = gameObject.transform.position.x - 2;
		limitYneg = gameObject.transform.position.y - 2;
		limitXpos = gameObject.transform.position.x + 2;
		limitYpos = gameObject.transform.position.y + 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Random.Range(0,2)==1){
			
		}else{
			
			}
	}
}
