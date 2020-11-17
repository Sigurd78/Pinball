using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallCount : MonoBehaviour
{
    static public int pinballCount = 5;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/
    void Awake()
    {                                                           // a
        // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("BallCount"))
        {                               // b
            pinballCount = 5;
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("BallCount", pinballCount);                              // c
    }


    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Balls Left: " + pinballCount;

        if (pinballCount < PlayerPrefs.GetInt("BallCount"))
        {                       // d
            PlayerPrefs.SetInt("BallCount", pinballCount);
        }


    }
}
