using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    public Text countGT;
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";

        GameObject countGO = GameObject.Find("BallCounter");
        countGT = countGO.GetComponent<Text>();
        countGT.text = "5";
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);



           // ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
           // apScript.AppleDestroyed();

        }
    }


    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Bumper")
        {

            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }

        if (coll.gameObject.tag == "Tunnel")
        {

            int score = int.Parse(scoreGT.text);
            score += 250;
            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
        if (coll.gameObject.tag == "Rujnuj")
        {
            /*
            int pinballCount = int.Parse(countGT.text);
            pinballCount -= 1;
            countGT.text = pinballCount.ToString();
            */

            BallCount.pinballCount -= 1;
            
        }

    }
}
