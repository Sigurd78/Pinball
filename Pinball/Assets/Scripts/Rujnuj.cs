using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Rujnuj : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject ballPrefab;
    public int Balls = 5;

    /*private void Awake()
    {
        Transform launchPointTrans = transform.Find("SpawnPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPos = launchPointTrans.position;
    }*/

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;       
        if (collidedWith.tag == "Ball")
        {
            Balls -= 1;
            if (Balls > 0)
            {
                BallDrop();
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
            Destroy(collidedWith);
            //Balls--;
        }
    }
    void BallDrop()
    {
        /* ballPrefab = Instantiate<GameObject>(ballPrefab);
         ballPrefab.transform.position = launchPos;
         ballRigidbody = ballPrefab.GetComponent<Rigidbody>();
         ballRigidbody.isKinematic = true;*/
        Instantiate(ballPrefab, spawnpoint.transform.position, Quaternion.identity);
    }
}
