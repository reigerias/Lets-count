using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeManager : MonoBehaviour {
    private static int score, lastScore;
    // you will have to manually select all the images in the inspector
    public List<Sprite> motivations; // memes to display when prevScore - score <= 20
    public List<Sprite> provocations; // memes to display when prevScore - score <= 10
    public List<Sprite> demotivations;//memes displayed when score -prevScore <=5
    public List<Sprite> gratifications;//memes displayed on hiscore!
    //CanvasRenderer sr;

    void Start()
    {
        // reference to the SpriteRenderer component on your GameObject  
        score = ScoreManager.newScore;
        lastScore = ScoreManager.previousScore;
        showRandomImage();
    }

    void showRandomImage()
    {
        int x;
        // count the number of images that you have selected..
        // lets say you selected 30 images
        int[] count = new int[4];
        int[] index = new int[4];
        count[0]= motivations.Count;
        count[1] = provocations.Count;
        count[2] = demotivations.Count;
        count[3] = gratifications.Count;

        // randomly select any number
        for (int  i = 0; i < 4; i++ )
             index[i] = Random.Range(0, count[i]); // let's assume that the output is 5
        if (score < ScoreManager.hiscore)
        {
            if (score < lastScore)
            {
                if (lastScore - score <= 10) //display provocation memes!
                {
                    GetComponent<UnityEngine.UI.Image>().sprite = provocations[index[1]];
                }
                else if (lastScore - score >= 30)
                {
                    GetComponent<UnityEngine.UI.Image>().sprite = demotivations[index[2]];
                }
                else
                    GetComponent<UnityEngine.UI.Image>().sprite = demotivations[index[2]];
            }
            else if (score > lastScore)
            {
                if (score - lastScore <= 15)
                    GetComponent<UnityEngine.UI.Image>().sprite = motivations[index[0]];
            }
           
        }
        else
            GetComponent<UnityEngine.UI.Image>().sprite = gratifications[index[3]];

        // now we will assign an image from our list which is at index 5

    }
}
