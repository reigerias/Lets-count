using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	 //you will have to manually select all the images in the inspector
    public List<AudioClip> audios;
    
    //CanvasRenderer sr;

    void Start()
    {
        // reference to the SpriteRenderer component on your GameObject

        PlayRandomAudio();
    }

    void PlayRandomAudio()
    {
        
        int count = audios.Count;

        // randomly select any number between 0 and 30
        int index = Random.Range(0, count); // let's assume that the output is 5

        // now we will assign an image from our list which is at index 5
        GetComponent<AudioSource>().clip = audios[index];
         GetComponent<AudioSource>().Play(0);       
    }
}
